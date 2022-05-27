# Un juego más seguro    
Ya ves cómo está el tema de la seguridad en los ordenadores. Cada día hay noticias de hackers, espías informáticos, virus, etc. Todos tenemos que calentarnos la cabeza en cómo proteger nuestros sistemas informáticos. Si tu estas interesado en proteger el juego que habéis diseñado entonces quizá te interese el contenido de este material exclusivo que has ganado.  
       
La cosa empieza con la historia de Juan y María.     
## La triste historia de Juan y María       
Juan está desesperado. Necesita urgentemente 1000 euros por un asunto del que prefiere no dar explicaciones a nadie. Decide pedirle ese dinero a su amiga María. Le va a proponer que le lleve el dinero en metálico el martes a las 12 de la noche a un punto discreto de la ciudad.      
       
Le prepara una carta con esas instrucciones, pero justo cuando va a enviársela piensa que es un método peligroso porque alguien puede interceptar la carta y preparar una emboscada a María para robarle el dinero. Entonces la llama por teléfono para explicarle sus dudas y ella le dice: “!Pues dime las instrucciones por teléfono ahora!”. Pero él le contesta: “No, que con el rollo ese del programa Pegasus no me fio. Igual me están espiando el móvil”.     
       
María es una tía muy lista y tiene una idea.  Compra un candado y lo lleva a Correos. Allí les da las siguientes instrucciones. “Pongan mi nombre en este candado y entréguenselo abierto a la persona que venga a recogerlo. Yo me llevo a casa la llave del candado. De esta manera, la persona que recoja el candado podrá enviarme en una caja cerrada lo que quiera que solo yo podre abrir la caja”. En Correos aceptan y se quedan con el candado abierto a la espera de que alguien venga a reclamarlo.      
             
María llama a Juan para explicarle su idea. Pero Juan también es listo y le dice lo siguiente: “Para que tu idea funcione yo debo estar absolutamente seguro de que el candado que me den en correos es tuyo y no de cualquier otra persona que se haga pasar por ti. De hecho, si el puto programa Pegasus está en mi móvil ahora mismo alguien nos estará escuchando y mañana irá a correos a dejar un candado haciéndose pasar por ti. Yo recogeré el candado, te enviaré el mensaje, pero ellos interceptarán la caja y la abrirán con la llave de ese candado”. 
        
María comprende el problema y va a Correos para explicarlo. Allí le proponen una solución: “Nosotros podemos verificar que tú eres realmente Maria y poner tu nombre en tu candado. Eso sí, tu amigo debe fiarse de nosotros. Confiar en que hemos hecho una buena verificación”. A Maria le parece buena idea, saca sus documentos de identidad para que Correos pueda verificar que ella es realmente Maria. Cuando están a punto de acabar, el personal de Correos comprende que lo que está haciendo puede ser un servicio de futuro y decide cobrarle a Maria 100 euros por ese servicio de acreditación. Maria no tiene más remedio que aceptar.     
             
María llama a Juan y le explica la nueva situación. Ahora Juan puede ir a correos a buscar el candado con la seguridad de que le van a dar el candado de María, que solo ella puede abrir. Pero un segundo antes de colgar, María reacciona y dice: “Un momento. Si alguien acaba de escuchar nuestra conversación con el puto Pegasus de los cojones, puede que vaya a correos a pedir mi candado y enviarme un mensaje con instrucciones para hacerme una emboscada. Este sistema no es seguro”.    
       
Entonces Juan tiene otra idea. Va a Correos y les lleva un candado. Les propone que ellos se queden con la llave y que se la den a quien venga a buscarla. Él se llevará su candado. Además, les enseña sus documentos de identidad para acreditar que él es realmente Juan. Entonces les dice: “Deme el candado de María”. Mete el sobre con las instrucciones en una caja y la cierra con el candado de María. Además, le pone su propio candado y deja en Correos la caja con los dos candados.     
        
Cuando llega a casa, Juan llama a María y le explica lo siguiente: “Ve a Correos y pídeles la caja que he dejado para ti. Pídeles también mi llave. Ellos te pueden asegurar que esa llave es mía y de nadie más. Allí mismo trata de abrir el candado que lleva mi nombre. Si consigues abrirlo puedes estar segura de que esa caja la he dejado yo porque en Correos te asegurarán que la llave que te han dejado es mía y de nadie más (ya pagué yo también los 100 euros para que se asegurasen de eso). Cuando llegues a tu casa abre el candado que lleva tu nombre con tu llave. Yo estoy seguro de que ese candado es tuyo y solo lo puedes abrir tú, porque así me lo han asegurado en Correos.     
       
Convencidos de que el método ahora sí que seguro, Juan y Maria llevaron a cabo el plan. María se presentó con los 1000 euros en el lugar y la hora indicados en la carta, pero Juan no apareció. Resultó que habían tardado mucho tiempo en idear el sistema seguro. La mafia no esperó más y le cortó el cuello a Juan. Eso sí, desde aquel día, Correos se está forrando con el dinero que gana con ese nuevo servicio de comunicación segura inventado por Maria y Juan.  
       
## La esencia de la comunicación segura     
La historia de Juan y María ilustra los conceptos básicos en los que se fundamentan los modelos de comunicación segura usados hoy en día. El sistema tiene que garantizar dos cosas:      
            
•	Confidencialidad: el mensaje que envía Juan solo puede leerlo Maria (o viceversa)          
•	Autentificación: el mensaje que recibe Juan solo puede haber sido enviado por Maria (o viceversa)          
       
Para ello, cada implicado en la comunicación necesita una clave pública y una privada. Para Juan la clave pública es la llave de su candado. La deja en Correos y puede cogerla cualquiera. Pero la clave privada es el candado, que solo tiene él. Para María la cosa va al revés. Su clave pública es el candado que deja a su nombre en Correos y su clave privada es la llave que guarda en casa.        
              
Para garantizar autentificación, Juan cierra el mensaje con su candado y cualquiera puede abrirlo con su llave, que es pública, asegurándose de esta manera que el candado solo puede haberlo cerrado Juan.      
               
Para garantizar confidencialidad, Juan cierra el mensaje con el candado público de Maria, con la tranquilidad de que solo ella puede abrirlo con la llave privada que tiene en casa.          
            
Pero para que todo esto funcione se necesita una autoridad respetada por los implicados (en este caso, Correos) que certifique que la persona que deja en Correos su candado es realmente Maria y la que deja su llave es Juan.        
                
Un sistema así es el que necesitamos para garantizar comunicaciones seguras entre ordenadores. Pero claro, los ordenadores no trabajan con candados y llaves. Trabajan con números. ¿Es posible hacer algo así con números? Pues resulta que sí. Que solo necesitamos tres números.      
             
## El algoritmo RSA           
Tomemos los tres números siguientes: N = 77, E = 7 y D = 43. Supongamos que Juan quiere enviar a María por email un número secreto (por ejemplo, la contraseña de su caja fuerte). Pongamos que ese número es el 68, aunque la cosa va a funcionar con cualquier número menor que N. María envía a Juan los números N y E. Esa pareja de números constituye la clave pública de María. No importa que otras personas se enteren de esa pareja de números. Pero María guarda en secreto el número D (que es su clave privada).           
            
Para encriptar el número secreto, Juan hace la operación siguiente:           
         
(68<sup>E</sup>) módulo N      
            
El resultado de eso es 40, que es el número que envía a María. Cuando María recibe el número hace la operación siguiente:       
          
(40<sup>D</sup>) módulo N           
                 
Y obtiene como resultado el 68, la contraseña de la caja fuerte.  Obviamente eso no funciona con cualquier trio de números, pero si con otras combinaciones. Por ejemplo, puedes probar con estas:         
          
N = 77, E = 7 y D = 43         
N = 77, E = 13 y D = 37         
N = 77, E = 23 y D = 47         
         
Y también funciona con esta:         
           
N = 143, E = 23 y D = 47       
            
En este caso, se pueden enviar de forma segura números menores de 143.         
             
De hecho, hay infinidad de combinaciones de números que pueden usarse de esta forma. ¿Dónde está el truco de esta magia?        
               
Esta magia se debe a Rivest, Shamir y Adleman que en 1979 inventaron el algoritmo RSA (las iniciales de sus nombres) para generar números como los anteriores que puedan usarse como claves públicas y privadas. El algoritmo RSA no es muy complicado (el código que encontrarás en este repositorio genera esos números y no ocupa muchas líneas). Todo parte de dos números primos (por ejemplo, el 7 y el 11 para los ejemplos con N=77 o 11 y 13 para los ejemplos con N = 143).         
           
Naturalmente, el método tal y como lo he descrito no parece muy seguro. Si alguien intercepta la clave pública de María y el número secreto encriptado, puede intentar desencriptarlo probando la fórmula de desencriptación con todos los valores posibles de D (en el ejemplo, los números del 1 al 77). Un sencillo programa podría generar todas las posibilidades hasta encontrar un resultado que tenga sentido.          
            
Pero claro, la cosa se complica si los dos números primos elegidos son muy muy grandes (por ejemplo, con unos 300 dígitos cada uno). En ese caso, ni las computadoras más potentes pueden realizar esa exploración en un tiempo razonable. Y lo cierto es que hay mucha gente investigando en cómo obtener números primos muy grandes, precisamente para hacer más seguros los sistemas de encriptación (el record actual es un número primo que tiene 23 millones de dígitos, descubierto en 2016).         
            
El programa (Windows Forms) que puedes descargarte de este repositorio te permitirá jugar un poco con el algoritmo RSA. Si introduces dos números primos podrás obtener diferentes combinaciones de tres números para usarlos como claves públicas y privadas. Selecciona alguna de esas combinaciones y prueba a encriptar/desencriptar números y frases.     
            
Para encriptar números se usan exactamente las fórmulas que te he explicado antes. Para encriptar frases la cosa es un poco más elaborada. Se encripta por separado cada uno de los caracteres. Para ello se convierte cada carácter en un número del 0 al 94 (solo hay 94 caracteres imprimibles). Luego se encripta el número y se obtiene el carácter imprimible correspondiente al número resultante. La frase con los caracteres resultantes es la que se envía y se desencripta en el destino con el mismo procedimiento. Para que esto funcione tienes que buscar combinaciones en las que la N sea mayor a 94.              
              
## ¿Te animas a hacer más seguro vuestro juego?            
No te va a resultar difícil porque en vuestro juego los mensajes que intercambian clientes y servidor son frases, que pueden encriptarse/desencriptarse tal y como hace el programa que te regalo. Veamos algunos detalles, por si te animas a intentarlo.            
           
Supongamos que el juego es un chat multijugador. Imagina que cada cliente genera sus propias claves, usando el código de este repositorio. En el momento de iniciarse la partida, cada jugador debe enviar a través del servidor sus claves públicas (N,E) a todos los de la partida. Por tanto, antes de empezar a chatear todos tienen las claves públicas de todos. Cuando alguien quiere enviar una frase la tiene que enviar por separado a cada destinatario, encriptándola primero con la clave pública del destinatario. Ya se ve que esto no va a ser muy eficiente. Además, cuando uno de los participantes reciba un mensaje de otro no puede estar seguro de que sea realmente de quien dice ser. Necesitas algo más elaborado.        
           
Imagina que el servidor también genera sus claves y envía la clave pública a todos los de la partica. Además, el servidor también se ha guardado las claves públicas de todos. Ahora cuando uno quiere enviar una frase al chat la encripta con la clave pública del servidor. Cuando el servidor la recibe la desencripta y se la envía a cada uno de los participantes, pero encriptándola antes con las claves públicas de los participantes. De esta manera, reducimos un poco el tráfico entre el cliente que envía y el servidor. Pero aún queda en el aire el problema de garantizar que el que envía el mensaje es quien dice ser.          
             
Seguro que si te calientas un poco la cabeza darás con una solución mejor para el problema. Ánimo.         

