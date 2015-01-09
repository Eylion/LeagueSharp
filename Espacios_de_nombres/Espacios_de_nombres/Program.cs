
/*Los espacios de nobmres son un modo sencillo de tener todas las clases organizadas y estructuradas.
 * Podremos echar un vistazo a dichas clases desde el buscador de objetos (ctrl+alt+J)
 * Podremos usar clases con el mismo nombre en espacios de nobmres distintos
 * Podremos definir tantos espacios de nombres como necesitemos
*/


//Definir un espacio de nombres

namespace espacio_de_nombres
{
   ... //Código
}

//Usar un espacio de nombres

espacio_de_nombres.Clase.CP objeto = new espacio_de_nombres.Clase.CP(argumentos);

//Usos de directiva using (uso de espacio de nombres demasiado largo)

/*Si utilizamos un nombre que no se encuentra en el espacio de nombres donde lo queremos usar, el compilador revisará todos aquellos que se hayan especificado con la directiva using.
 *Ojo. Nosotros podemos usar cualquier miembro de los espacios de nombres sin necesidad de poner ninguna directiva using.
 */

    //Si quisiésemos utilizar la clase CP del espacio de nombres "espacio_de_nombres (sin using)"

    espacio_de_nombres.Clase.CP objeto = new espacio_de_nombres.Clase.CP(argumentos);
    
    //Si quisiésemos utilizar la clase CP del espacio de nombres "espacio_de_nombres (con using)"

    using espacio_de_nombres.Clase;
    ...
    CP objeto = new CP (argumentos);

//Ubicación directiva using
/*Se puede poner al principio de del programa, lo cual afectaría a todos los espacios de nombres o
 *Se puede poner dentro de un espacio de nombres siempre y cuando la declaremos antes de cualquier miembro de dicho espacio de nombres, sólo afectaría a los miembros del espacio de nombres 
 */
#region
using System.Console;
namespace Espacio1
{
    ...
    WriteLine("Hola");
    ...
}
namespace Espacio2
{
    ...
    WriteLine("Hola");
    ...
}    
#endregion
#region
namespace Espacio1
{
    using System.Console;
    ...
    WriteLine("Hola");
    ...
}
namespace Espacio2
{
    ...
    WriteLine("Hola"); //Aquí daría error dado que la directiva using sólo se aplica en Espacio1 y no en Espacio2
    ...
}    
#endregion


//Usos de directiva using (Alias)
/*Puede resultar útil cuando la clase es demasiado larga.
 */

using ESN = espacio_de_nombres; //A partir de ahora ESN es espacio_de_nombres

...
ESN.Clase modulo = new ESN.Clase();
...

