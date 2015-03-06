using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseCrudLinq
    {
        ConexionLinqDataContext db = new ConexionLinqDataContext(); //dataContextLinq

        public void guardar(string nom_, string num_)
        {

            #region btnGuardarLosdatos
            Usuario  u = new Usuario(); //llama tabla
            u.nombre = nom_;
            u.numero = num_;

            db.Usuarios.InsertOnSubmit(u);
            db.SubmitChanges();
            #endregion
        }

        public void mostrar(ListBox lb)
        {
            #region mostrarDatosLinq
            var consultar = from u in db.Usuarios
                            select u;
            foreach (Usuario us in consultar)
            {
                lb.Items.Add( us.codigo+" "+us.nombre +" "+ us.numero);
            }
            #endregion
        }
        
    public void mostrar(ComboBox cbo)
        {
            #region  MostrarComboLinq
            var consultar = from u in db.Usuarios
                            select u;
            foreach (Usuario us in consultar)
            {
                cbo.Items.Add(us.nombre);
            }
            #endregion
        }

    int id=0;
    public void obtenerid(string dato)
    {
        #region obtenerIDlinq
        var consultar = from u in db.Usuarios 
                        where u.nombre==dato 
                        select u;
        foreach (Usuario us in consultar)
        {
            id = us.codigo ;
        }
        #endregion  
    }

        public void modificar(string nom,string num, string dat)
    {


        #region modificarLinq
        obtenerid(dat);
                var consultar = (from u in db.Usuarios
                                        where  u.codigo  ==id
                                        select u).First();
                consultar.nombre = nom;
               consultar.numero= num;
               db.SubmitChanges();

        #endregion
    }

            public void cargar (string dat,TextBox nombre ,TextBox numero)
        {

            #region cargarLosDatosDeLaConsulta
            obtenerid(dat);
               var consultar = from u in db.Usuarios
                               where u.codigo == id
                               select u;

               foreach (Usuario usu in consultar)
               {
                   nombre.Text = usu.nombre;
                   numero.Text = usu.numero;
               }
            #endregion
        }

            public void Eliminar(string dato)
            {

                #region eliminarDatoslinq
                var consultar = from u in db.Usuarios
                                where (u.codigo +" "+u.nombre+" "+u.numero)==dato
                                select u;
                foreach (Usuario usu in consultar)
                {
                    db.Usuarios.DeleteOnSubmit(usu);
                }
                db.SubmitChanges();
                #endregion
            }



        
    
    
    
    
    
    }
}
