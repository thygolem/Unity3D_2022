¿En qué consiste el juego?

¿Cuántos objetos identificas?

¿Qué objetos son puramente estáticos y cuáles tienen comportamiento?

¿Qué comportamientos identificas?

¿Quién tiene la resposabilidad de esos comportamientos?

¿Qué elementos tienen el HUD (Head Up Display)?


- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
- - - - - - - - - - - - - - - - - - - - - - - - - - P O N G - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
PONG

¿En qué consiste el juego?
    Hay dos jugadores que aparecen como palas en los laterales derecho e izquierdo
    Simula tenis de mesa
        - Objetivos:
            Obtener puntos, ¿Cómo se obtienen los puntos?
                Marcando la pelota en la portería contraria
            defender tu portería


¿Qué objetos identificas?
    Palas (Izquierda y Derecha)
    Marcadores de puntos
    Líneas de centro de campo o red
    pelota
    Portería 
    Paredes supoerior en inferior
    Color de fondo


¿Qué objetos son puramente esteticos y cuáles tienen comportamiento?
    Puramente estéticos: red y color de fondo 
    Los demás tienen comportamiento



¿Qué comportamientos identificas?
    Pala:
        Visualmente es un rectángulo
        Avatar que manejamos y se mueve certicalmente
        Hace rebotar la pelota
        tiene limites en su movimiento
        Al chocar la pelota, emite sonido
    Pelota:
        Visualmente es un cuadrado
        Tiene físicas ¿Qué físicas?
        Al chocar recto (movimiento horizontal de la pelota) con la pala, su velocidad es menor
        Su posición se resetea cuando se ha marcado un GOL
            Hay variarion en su posición al resetearse
            Aparece una vez que ha terminado el sonido de GOL
            La dirección de la pelota es hacia el juagdor al que le han metido GOL
        la pelota choca con las palas y las paredes
            Choque con las paredes: rebote elásticoo
            Rebote con las palas: por definir
        Con las poerterías ¿Hay choque?

    Marcador:
        Hay dos, un por jugador en su lado respectivo de la pantalla (izquierdo y derecho)
        Aumenta cuando la pelota entra en la portería contraria (GOL)
    Portería:
        No se renderiza
        Una por cada jugador
        Detecta si la pelota ha entrado -> GOL
        Emite un sonido cuando hay GOL
    Paredes:
        No se renderizan
        Hay 2, inferior y supoerior
        Hacen rebotar la pelota
        Emite sonido al chocar la pelota en ellas



¿Quién tiene la resposabilidad de esos comportamientos?


¿Qué elementos tienen el HUD (Head Up Display)?
Marcador de cada juagdor


[fuentedeljuego] (https://www.dafont.com/es/pixellari.font)
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
- - - - - - - - - - - - - - - - - - - - - - - - - - P O N G - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
