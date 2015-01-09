#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
//Todo programa en C# se organiza por clases y estructuras.
//Construir una clase

class Clase1
{
   //Aquí van los miembros de la clase.
}

//Se denomina miembros de una clase a los campos (variables dentro de la clase), constantes, constructores, eventos, métodos, propiedades, etc.… que la componen.


//MODIFICADORES Estos se ponen porque puede que necesites una clase que sólo se pueda usar por código que pertenezca al mismo ensamblado.

//internal. Clases y miembros. El acceso está limitado desde el mismo ensamblado. Es el modificador de acceso por defecto.

//private. Miembros. Solamente será visible desde dentro del cuerpo de la clase. Es el modificador más restrictivo.

//protected. Miembros. El acceso está limitado sólo a la clase o a clases heredadas de la misma.

//protected internal. Miembros. Es la combinación de ambos modificadores.

//public. Clases y miembros. Será visible desde dentro del mismo ensamblado o desde otro ensamblado que haga referencia a este. Es el modificador menos restrictivo.

//Clase Usuario: Ensamblado CSharpClass.Common
namespace CSharpClass.Common
{
    public class Usuario
    {
        public Usuario(int usuarioId, DateTime fechaRegistro)
        {
            UsuarioId = usuarioId;
            FechaRegistro = fechaRegistro;
        }

        //UsuarioId. Visible en cualquier ensamblado.
        public int UsuarioId { get; set; }
        //FechaRegistro. Sólo es accesible en el cuerpo de esta clase.
        private DateTime FechaRegistro { get; set; }
        //NumeroAñosDesdeRegistro. Sólo es accesible en esta clase y las que hereden de esta.
        protected int NumeroAñosDesdeRegistro
        {
            get { return DateTime.Now.Year - FechaRegistro.Year; }
        }
    }
}

//Clase Candidato: Ensamblado CSharpClass.Common

namespace CSharpClass.Common
{
    public class Candidato : Usuario
    {
        public Candidato(int usuarioId, DateTime fechaRegistro)
            : base(usuarioId, fechaRegistro)
        {
        }

        public bool EsRegistradoAntiguo
        {
            get
            {
                //Accede a la propiedad NumeroAñosDesdeRegistro de Usuario
                return NumeroAñosDesdeRegistro > 5;
            }
        }
    }
}

//ConsoleApp. Ensamblado: CSharpClass.ConsoleApp
namespace CSharpClass.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var candidato = new Candidato(1, new DateTime(2009, 01, 13));
            Console.WriteLine(String.Format("UsuarioId {0} - Es Antiguo: {1}", candidato.UsuarioId,
                candidato.EsRegistradoAntiguo));
            Console.Read();
        }
    }
}

//MODIFICADORES DE TIPO
/*abstract.
    Clases. Cuando se define una clase como abstract esta no puede ser instanciada y sólo puede usarse si otra clase hereda de esta.
    Miembros. Cuando se definen los miembros de una clase como abstract, la clase que hereda de esta, está obligada a implementarlos. Para sobrescribirlos se utiliza el modificador override.
 * 
override. Miembros. Se utiliza para implementar miembros de clases definidos como abstract o virtual.
 * 
partial. Clases. Se utiliza para definir la clase en diferentes archivos de un mismo ensamblado.
 * 
readonly. Se utiliza en campos para que el valor sólo pueda modificarse en la propia definición o en el constructor.
 * 
sealed. Clases y miembros. Cuando utilizamos este modificador lo que conseguimos es que no se pueda derivar/ heredar.
 * 
static.
    Clases. Utilizando este modificador en una clase conseguimos que dicha clase no se pueda instanciar, ni heredar (sealed) y sólo contiene miembros estáticos. ¿Cuándo usarlas? Según la MSDN “Utilice una clase estática como unidad de organización para métodos no asociados a objetos concretos”.
    Miembros. Utilizando este modificador en un miembro conseguimos que pertenezca a la propia clase y no al objeto, de tal forma“ que para acceder a dicho miembro utilizaremos el nombre de la clase y no el del objeto.+
 * 
virtual. Miembros. Al utilizar este modificador permitimos que el miembro se pueda sobrescribir en una clase derivada.
*/

//Clase abstracta OfertaRegistro: Ensamblado CSharpClass.Common
namespace CSharpClass.Common
{
    public abstract class OfertaRegistro
    {
        public DateTime FechaAlta { get; private set; }
        public DateTime FechaCaducidad { get; set; }
        protected void Registrar()
        {
            FechaAlta = DateTime.UtcNow;
        }
        public abstract void RegistrarOfertar();
        protected virtual void AsignarCaducidad()
        {
            FechaCaducidad = DateTime.Now.AddMonths(6);
        }
    }
}

//Clase sellada Oferta que hereda de OfertaRegistro: Ensamblado CSharpClass.Common

namespace CSharpClass.Common
{
    //Sealed. No se puede heredar
    public sealed class Oferta : OfertaRegistro
    {
        //Sobrescribe el método abstracto RegistrarOferta
        public override void RegistrarOfertar()
        {
            Registrar();
            AsignarCaducidad();
        }
    }
}

//Clase sellada OfertaPremium que hereda de OfertaRegistro: Ensamblado CSharpClass.Common

namespace CSharpClass.Common
{
    public sealed class OfertaPremium : OfertaRegistro
    {
        public override void RegistrarOfertar()
        {
            Registrar();
            AsignarCaducidad();
        }

        //Sobrescribe el método virtual RegistrarOferta
        protected override void AsignarCaducidad()
        {
            FechaCaducidad = DateTime.Now.AddMonths(9);
        }
    }
}

//MIEMBROS DE UNA CLASE

/*Campos. Variables declaradas en el ámbito de una clase.
 * 
Constantes. Campos o propiedades cuyo valor se establece en tiempo de compilación y este permanece inalterable.
 * 
Propiedades. Métodos a los que se accede como si fueran campos.
 * 
Métodos. Acciones que una clase puede realizar.
 * 
Eventos. Es la forma que tiene c# para que una clase pueda enviar notificaciones a sus clientes cuando sucede “algo”.
 * 
Operadores.
 * 
Indizadores.
 * 
Constructores. Son métodos a los que se llama cuando el objeto se crea por primera vez.
 * 
Destructores. Son métodos a los que se llama cuando el objeto va a quitarse de la memoria.
 * 
Tipos anidados.
*/