using Grillas;
using Maestros;
using System;
using System.Drawing;
using System.Windows.Forms;
using TemparioGestion.Properties;
using Temparios;
namespace TemparioGestion
{
    public partial class FormTemparioGestion : Form
    {
        public FormTemparioGestion()
        {
            InitializeComponent();
            BotonCerrar.Click += BotonCerrar_Click;
            BotonEjecutar.Click += BotonEjecutar_Click;
            GrillaDetalle.MouseClick += GrillaDetalle_MouseClick;
            GrillaDetalleArmado.MouseClick += GrillaDetalleArmado_MouseClick;
            GrillaRepuestos.MouseClick += GrillaRepuestos_MouseClick;
            GrillaResumen.CellEnter += GrillaResumen_CellEnter;
            Marca.SelectionChangeCommitted += Marca_SelectionChangeCommitted;
            MenuAbrirTempario.Click += MenuAbrirTempario_Click;            
        }

        private enum FilasResumen
        {
            Marca, Modelo, Mecanicos, HorasDesarme, HorasArmado, TotalHoras
        }

        readonly DataGridViewTextAndImageColumn colNumeroDet = new DataGridViewTextAndImageColumn(Resources.abrir0);
        readonly DataGridViewTextAndImageColumn colNumeroArmado = new DataGridViewTextAndImageColumn(Resources.abrir0);
        readonly DataGridViewTextAndImageColumn colNumeroRep = new DataGridViewTextAndImageColumn(Resources.abrir0);

        private const string PesoEtapa = "Peso / Estapas";
        private const string Mecanicos = "Mecánicos";
        private const string HorasDesarme = "Horas Desarme y evaluación";
        private const string HorasArmado = "Horas Armado y ajustes";
        private const string TotalHoras = "Total horas de Reparacion";
        private const int ColumnaInicioModelos = 1;
        private const int AreaClickAbrirDoc = 18;
        private void ConfigurarGrillaResumen()
        {
            GrillaResumen.ScrollBars = ScrollBars.Both;

            //GrillaResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GrillaResumen.SelectionMode = DataGridViewSelectionMode.CellSelect;
            GrillaResumen.ColumnHeadersHeight = 40;
            GrillaResumen.Columns.Add("Items", "Items / Modelos");
            //GrillaResumen.Columns.Add("mecanico", "Mecánicos");
            //GrillaResumen.Columns.Add("carga", "Cargadas");            
            GrillaResumen.RowCount = 6;
            GrillaResumen.Rows[(int)FilasResumen.Marca].Visible = false;
            GrillaResumen.Rows[(int)FilasResumen.Modelo].Visible = false;
            GrillaResumen.Columns[0].Width = 165;
            //GrillaResumen.Columns[1].Width = 60;
            //GrillaResumen.Columns[2].Width = 60;

            GrillaResumen[0, (int)FilasResumen.Marca].Value = "Marca";
            GrillaResumen[0, (int)FilasResumen.Modelo].Value = "Modelo";

            GrillaResumen[0, (int)FilasResumen.Mecanicos].Value = Mecanicos;
            GrillaResumen[0, (int)FilasResumen.HorasDesarme].Value = HorasDesarme;
            GrillaResumen[0, (int)FilasResumen.HorasArmado].Value = HorasArmado;
            GrillaResumen[0, (int)FilasResumen.TotalHoras].Value = TotalHoras;
            GrillaResumen[0, (int)FilasResumen.TotalHoras].Style.Font = new Font(GrillaResumen.Font.Name, GrillaResumen.Font.Size + 1, FontStyle.Bold);
            GrillaResumen.Columns[0].Frozen = true;
        }
        private void ConfigurarGrillaDetalle(DataGridView flex)
        {
            string titulo;
            Padding pad = new Padding(20, 0, 0, 0);
            if (flex.Name == GrillaDetalle.Name)
            {
                colNumeroDet.DefaultCellStyle.Padding = pad;
                colNumeroDet.HeaderText = "#";

                flex.Columns.Add(colNumeroDet);
                titulo = "Temparios Evaluación - Tarea";
            }
            else
            {
                colNumeroArmado.DefaultCellStyle.Padding = pad;
                colNumeroArmado.HeaderText = "#";
                flex.Columns.Add(colNumeroArmado);
                titulo = "Temparios Reparación - Tarea";
            }

            flex.ScrollBars = ScrollBars.Both;
            flex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            flex.Columns.Add("item", "Item");
            flex.Columns.Add("proc", "Proceso");
            flex.Columns.Add("tarea", titulo);
            flex.Columns.Add("horas", "Horas");

            flex.Columns[0].Width = 40;
            flex.Columns[1].Width = 50;
            flex.Columns[2].Width = 70;
            flex.Columns[4].Width = 70;
        }
        private void ConfigurarGrillaRepuestos()
        {
            Padding pad = new Padding(20, 0, 0, 0);
            GrillaRepuestos.ScrollBars = ScrollBars.Both;
            GrillaRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            colNumeroRep.DefaultCellStyle.Padding = pad;
            colNumeroRep.HeaderText = "#";
            GrillaRepuestos.Columns.Add(colNumeroRep);

            // GrillaRepuestos.Columns.Add("num", "#");
            GrillaRepuestos.Columns.Add("item", "Item");
            GrillaRepuestos.Columns.Add("codigo", "Codigo");
            GrillaRepuestos.Columns.Add("art", "Artículo");
            GrillaRepuestos.Columns[0].Width = 40;
            GrillaRepuestos.Columns[1].Width = 50;
            GrillaRepuestos.Columns[2].Width = 70;

        }

        private void ListarMarcas()
        {
            var mrc = new Maestros.Marcas(1);
            var marcas = mrc.Listar();
            Marca.DataSource = marcas;
            Marca.DisplayMember = "Marca";
            Marca.ValueMember = "Marca";
            Marca.SelectedIndex = -1;
        }
        private void ListarModelo()
        {
            try
            {
                var mrc = new Marcas
                {
                    Marca = Marca.SelectedValue.ToString().Trim()
                };
                var mod = new Modelos(1, mrc);
                mod.Listar(Modelo);
                Modelo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                //SetErrorMsg(ex.Message);
            }
        }

        private void ListarSecciones()
        {
            var mrc = new Maestros.Organizacion.GenNivel5()
            {
                SeccionProduccion = true
            };
            mrc.Listar(Seccion);
        }

        private void ListarMarcaModeloTempario()
        {
            GrillaResumen.Columns.Clear();
            GrillaDetalle.Rows.Clear();
            GrillaDetalleArmado.Rows.Clear();
            GrillaRepuestos.Rows.Clear();
            ConfigurarGrillaResumen();
            var temp = new Tempario()
            {
                Marca = Marca.SelectedValue != null ? Marca.SelectedValue.ToString() : string.Empty,
                Modelo = Modelo.SelectedValue != null ? Modelo.SelectedValue.ToString() : string.Empty
            };
            int.TryParse(Seccion.SelectedValue != null ? Seccion.SelectedValue.ToString() : string.Empty, out int codigoSec);
            var listaModelos = temp.ListarModelosSeccion(codigoSec);
            if (listaModelos.Count > 0)
            {
                foreach (var modelo in listaModelos)
                {
                    GrillaResumen.Columns.Add(modelo.Modelo, modelo.Marca + " " + modelo.Modelo);
                    int col = GrillaResumen.Columns.Count - 1;
                    GrillaResumen[col, (int)FilasResumen.Marca].Value = modelo.Marca;
                    GrillaResumen[col, (int)FilasResumen.Modelo].Value = modelo.Modelo;
                    GrillaResumen.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }
        private void HorasPorModelo()
        {
            var temp = new TemparioDetalle();
            int.TryParse(Seccion.SelectedValue != null ? Seccion.SelectedValue.ToString() : string.Empty, out int codigoSec);
            for (int i = ColumnaInicioModelos; i < GrillaResumen.ColumnCount; i++)
            {
                string marca = GrillaResumen[i, (int)FilasResumen.Marca].Value.ToString();
                string modelo = GrillaResumen[i, (int)FilasResumen.Modelo].Value.ToString();
                double horasEval = temp.HorasPorModelo(1, codigoSec, marca, modelo);
                double horasRepar = temp.HorasPorModelo(2, codigoSec, marca, modelo);
                int mecanicos = temp.MecanicosPorTempario(1, codigoSec, marca, modelo);
                GrillaResumen[i, (int)FilasResumen.HorasDesarme].Value = horasEval;
                GrillaResumen[i, (int)FilasResumen.HorasArmado].Value = horasRepar;
                GrillaResumen[i, (int)FilasResumen.TotalHoras].Value = horasEval + horasRepar;
                GrillaResumen[i, (int)FilasResumen.Mecanicos].Value = mecanicos;
            }
        }
        private void DetallePorModelo(DataGridView flex, string marca, string modelo, int tipo)
        {
            flex.Rows.Clear();
            var temp = new TemparioResumen();
            int.TryParse(Seccion.SelectedValue != null ? Seccion.SelectedValue.ToString() : string.Empty, out int codigoSec);
            var lst = temp.ListarGestion(tipo, codigoSec, marca, modelo);

            foreach (var item in lst)
            {
                flex.Rows.Add(item.Numero, item.Item, item.Proceso, item.Tarea, item.Horas);
            }
        }
        private void RepuestoPorModelo(string marca, string modelo, int tipo)
        {
            GrillaRepuestos.Rows.Clear();
            var temp = new TemparioResumen();
            int.TryParse(Seccion.SelectedValue != null ? Seccion.SelectedValue.ToString() : string.Empty, out int codigoSec);
            var lst = temp.ListarRepuestos(tipo, codigoSec, marca, modelo);
            foreach (var item in lst)
            {
                GrillaRepuestos.Rows.Add(item.Numero, item.Item, item.CodigoRepuesto, item.DescripRepuesto);
            }
        }
        private void AjustaControles()
        {
            GrupoDet.Width = Width / 2;
            GrupoRep.Location = new Point(GrupoDet.Width, GrupoDet.Top);
            GrupoRep.Width = GrupoDet.Width - 20;
            GrillaDetalle.Height = GrupoDet.Height / 2;
            GrillaDetalleArmado.Top = GrillaDetalle.Top + GrillaDetalle.Height;
            GrillaDetalleArmado.Height = (GrupoDet.Height / 2) - 20;
        }

        #region Eventos
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            //Resolución pantalla
            //int rect = Screen.PrimaryScreen.Bounds.Width;            
            Grilla.FormatoPlanillas(GrillaResumen);
            Grilla.EvitaParpadeoGrilla(GrillaResumen);
            Grilla.FormatoPlanillas(GrillaDetalle);
            Grilla.EvitaParpadeoGrilla(GrillaDetalle);
            Grilla.FormatoPlanillas(GrillaDetalle);
            Grilla.EvitaParpadeoGrilla(GrillaDetalle);
            Grilla.FormatoPlanillas(GrillaDetalleArmado);
            Grilla.EvitaParpadeoGrilla(GrillaDetalleArmado);
            Grilla.FormatoPlanillas(GrillaRepuestos);
            Grilla.EvitaParpadeoGrilla(GrillaRepuestos);
            Grilla.Imagen = Resources.abrir0;
            ConfigurarGrillaResumen();
            ConfigurarGrillaDetalle(GrillaDetalle);
            ConfigurarGrillaDetalle(GrillaDetalleArmado);
            ConfigurarGrillaRepuestos();
            AjustaControles();
            ListarMarcas();
            ListarSecciones();


        }
        private void BotonEjecutar_Click(object sender, EventArgs e)
        {
            ListarMarcaModeloTempario();
            HorasPorModelo();
        }
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GrillaDetalle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X < AreaClickAbrirDoc)
            {
                AbrirTempario(GrillaDetalle);
            }
        }
        private void GrillaRepuestos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X < AreaClickAbrirDoc)
            {
                AbrirTempario(GrillaRepuestos);
            }
        }

        private void GrillaDetalleArmado_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X < AreaClickAbrirDoc)
            {
                AbrirTempario(GrillaDetalleArmado);
            }
        }

        private void AbrirTempario(DataGridView flex)
        {
            string numero = flex[0, flex.CurrentRow.Index].Value.ToString();
            var app = new AbrirAplicacion.AbrirApp("TemparioForm", new string[] { numero });
            if (app.Mensaje != string.Empty)
                MessageBox.Show(app.Mensaje);
        }
        private void GrillaResumen_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GrillaResumen[e.ColumnIndex, 0].Value == null || e.ColumnIndex < ColumnaInicioModelos || e.RowIndex == 0) return;
            string marca = GrillaResumen[e.ColumnIndex, (int)FilasResumen.Marca].Value.ToString();
            string modelo = GrillaResumen[e.ColumnIndex, (int)FilasResumen.Modelo].Value.ToString();
            DetallePorModelo(GrillaDetalle, marca, modelo, 1);
            DetallePorModelo(GrillaDetalleArmado, marca, modelo, 2);
            RepuestoPorModelo(marca, modelo, 1);
        }
        private void Marca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListarModelo();
        }

        private void MenuAbrirTempario_Click(object sender, EventArgs e)
        {
            Type t = ActiveControl.GetType();
            if (t.Equals(typeof(DataGridView)))
            {
                var flex = (DataGridView)ActiveControl;
                if (int.TryParse(flex[0, flex.CurrentRow.Index].Value.ToString(), out int numero))
                {
                    var app = new AbrirAplicacion.AbrirApp("TemparioForm", new string[1] { numero.ToString() }, true);

                    string msg = app.Mensaje;
                    if (msg != string.Empty)
                        MessageBox.Show(msg);
                }

            }
        }

        #endregion
    }
}
