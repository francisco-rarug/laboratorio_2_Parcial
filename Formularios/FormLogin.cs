namespace Rarug.Francisco.Parcial;
using Fabrica;
using System.Reflection;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnIngresar_Click_1(object sender, EventArgs e)
    {
        try
        {
            string usuario = this.textBoxUsername.Text;
            string password = this.textBoxPassword.Text;
            Rango rangoAuxiliar;

            if (rbOperario.Checked)
            {
                rangoAuxiliar = Rango.Operario;
            }
            else
            {
                rangoAuxiliar = Rango.Supervisor;
            }

            if (rangoAuxiliar == Rango.Operario)
            {
                Operario operario = Operario.BuscarPorUsuarioYRango(usuario, password, rangoAuxiliar, BaseDeDatosDAO.LeerOperarios());
                if (operario != null)
                {
                    MessageBox.Show(operario.Mostrar(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormFabricaOperario formFabrica = new FormFabricaOperario();
                    Hide();
                    DialogResult result = formFabrica.ShowDialog();
                    if (result == DialogResult.Cancel) Show();
                    return;
                }
            }
            else
            {
                Supervisor supervisor = Supervisor.BuscarPorUsuarioYRango(usuario, password, rangoAuxiliar, BaseDeDatosDAO.LeerSupervisor());
                if (supervisor != null)
                {
                    MessageBox.Show(supervisor.Mostrar(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormFabricaSupervisor formFabrica = new FormFabricaSupervisor();
                    Hide();
                    DialogResult result = formFabrica.ShowDialog();
                    if (result == DialogResult.Cancel) Show();
                    return;
                }
            }

            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
        }
    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnHardSuper_Click(object sender, EventArgs e)
    {
        try
        {
            List<Supervisor> supervisores = BaseDeDatosDAO.LeerSupervisor();

            if (supervisores.Count > 0)
            {
                
                textBoxUsername.Text = supervisores[0].Usuario;
                textBoxPassword.Text = supervisores[0].Password;
                rbSupervisor.Checked = true;
            }
            else
            {
                MessageBox.Show("No hay supervisores registrados en la base de datos.");
            }
        }
        catch (Exception ex)
        {
            Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
        }

    }

    private void btnHardOper_Click(object sender, EventArgs e)
    {
        try
        {
            List<Operario> operario = BaseDeDatosDAO.LeerOperarios();

            textBoxUsername.Text = operario[0].Usuario;
            textBoxPassword.Text = operario[0].Password;
            rbOperario.Checked = true;
            
        }
        catch (Exception ex)
        {
            Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
        }
    }
}


