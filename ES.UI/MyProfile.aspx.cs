using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Diagnostics;

namespace ES.UI
{
    public partial class MyProfile : System.Web.UI.Page
    {
        private static string _Usuario;
        string foto = string.Empty;

        private IUsuarios _usu;
        private IHerramientas _herra;

        public MyProfile()
        {
            _usu = new MUsuarios();
            _herra = new MHerramientas();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _Usuario = Context.User.Identity.Name;

            var res = _usu.ObtenerInfo(_Usuario);

            foto = _herra.Decrypt(res[0].FOTO);
            username.Text = _herra.CapitalizeByWord(_herra.Decrypt(res[0].NOMBRE) + " " + _herra.Decrypt(res[0].APELLIDOS));
            email.Text = _herra.Decrypt(res[0].EMAIL).ToLower();
            phrase.Text = _herra.Capitalize(_herra.Decrypt(res[0].FRASE));
            user.Text = _herra.Capitalize(_herra.Decrypt(res[0].USUARIO));
            tel.Text = _herra.Decrypt(res[0].TELEFONO);
            role.Text = _herra.Capitalize(_usu.ObtenerRol(res[0].ID_ROL));

            E_Role.Text = role.Text;
            E_IdCard.Text = _herra.Decrypt(res[0].CEDULA);
        }

        public void Foto()
        {
            Response.Write(foto);
        }

        public void Usuarios()
        {
            var GetTotalUsuarios = _usu.TotalUsuarios();
            var GetInfoUsuarios = _usu.ObtenerInfoGeneral();

            for (int i = 0; i < GetTotalUsuarios; i++)
            {
                var Rol = _usu.ObtenerRol(GetInfoUsuarios[i].ID_ROL);

                Response.Write("<li>" +
                                   "<div class='row'>" +
                                       "<div class='col-xs-3'>" +
                                           "<div class='avatar'>" +
                                               "<img src='" + _herra.Decrypt(GetInfoUsuarios[i].FOTO) + "' class='img-circle img-no-padding img-responsive custom_10'>" +
                                           "</div>" +
                                       "</div>" +

                                       "<div class='col-xs-6 custom_17'>" +
                                           _herra.CapitalizeByWord(_herra.Decrypt(GetInfoUsuarios[i].NOMBRE) + " " + _herra.Decrypt(GetInfoUsuarios[i].APELLIDOS)) + "<br />" +
                                           "<span><small class='custom_11'>" + _herra.Capitalize(Rol) + "</small></span><br />" +
                                           "<span><small class='custom_11'>" + _herra.Decrypt(GetInfoUsuarios[i].TELEFONO) + "</small></span><br />" +
                                       "</div>" +
                                   "</div>" +
                               "</li>");
            }
        }

        protected void btn_UpdateProfile_Click(object sender, EventArgs e)
        {
            if (E_FirstName.Text == string.Empty || E_LastName.Text == string.Empty || E_Email.Text == string.Empty || E_Telephone.Text == string.Empty || E_Phrase.Value == string.Empty)
            {
                // Do nothing
            }
            else
            {
                var UpdateProfile = new TB_Usuarios
                {
                    USUARIO = _Usuario,
                    NOMBRE = _herra.Encrypt(E_FirstName.Text.ToUpper()),
                    APELLIDOS = _herra.Encrypt(E_LastName.Text.ToUpper()),
                    TELEFONO = _herra.Encrypt(E_Telephone.Text),
                    EMAIL = _herra.Encrypt(E_Email.Text.ToUpper()),
                    FRASE = _herra.Encrypt(E_Phrase.Value.ToUpper()),
                };

                _usu.ActualizarPerfil(UpdateProfile);
            }

            Response.Redirect("MyProfile.aspx");
        }
    }
}