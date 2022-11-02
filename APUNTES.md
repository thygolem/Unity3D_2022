# Fechas de pruebas y tests por módulo
## Módulo 1 - (4/Nov)
### Prueba()
 - 

## Módulo 2 - (16/Nov)
### Prueba()
 - 

## Módulo 3 - (18/Nov)
### Prueba()
 -
 
## Módulo 4 - (30/Nov)
### Prueba()
 -

## Módulo 5 - (2/Dic)
### Prueba()
 - 




# TÉRMINOS

## RAYCASTHIT
- Un rayo es una línea infinitamente larga emitida desde un punto en una dirección en un mundo tridimensional.
En la trayectoria del rayo, una vez que colisiona con el modelo con el colisionador agregado, dejará de lanzarse. 
Podemos usar rayos para detectar balas que golpean objetivos y clics del mouse para recoger objetos.
[example](https://www.youtube.com/watch?v=7ybz28Py0-U)




## POO

- Herencia
  - 
- Cohesion
  - Una clase debe tener sentido en sí misma
- Abstraccion
  - 
- Polimorfismo
  - Un objeto puede tomar la forma de otro
- Acoplamiento
  - 
- Encapsulamiento
  - Capacidad de restringir acceso a algunas partes de código




### Poo vs Estructurada.
- Poo puede usar elemntos de diferentes objetos y estructurada son procedimientos

  - C = estructurada (no hay clases)
  - C# = objetos (hay clases)




### C#
- Variables de clase = estado
- Método = comportamiento

### Sobrecarga de métodos
- Cuando usamos el msimo nombre para varios métodos donde cada uno de ellos usa diferentes variables.

### Métodos estáticos
Son métodos independientes de la definición de objetos. Un método estático puede llamarse sin tener que crear un objeto de dicha clase. Tiene restricciónes. No puede acceder a los atributos de la clase (salvo que sean estáticos).
No puede utilizar el operador this, ya que este método se puede llamar sin tener que crear un objeto de la clase.
Puede llamar a otro método siempre y cuando sea estático.
Un método estático es lo más parecido a lo que son las funciones en los lenguajes estructurados (con la diferencia que se encuentra encapsulado en una clase)



### Type Casting
Fundamental para comprender el polimorfismo
Informamos al compilador de que una variable puede ser usada por otro tipo
n1 = 5
n2 = 2
n3 = (float) n1 /n2
n3 = 2.5


# Tokenizacion meduante diagramas de modelo de dominio con UML
Analisis de clases conceptuales (tokens)
....
Token significa símbolo o ficha

Tokens pueden establecerse de forma jeráquica con el Game World (Zona de juego) como raíz.

Todos los tokens deben formar parate del game world token

Por ejemplo, el token para el avatar del jugador actúa como usaer interface entre el jugador y el juego.


Se crean plantillas, matrices, para mostrar las interacciones entre los tokens

  1 | 2 | 3 | 4
1 x
2 .   x   .   . 
3 .   x   x   .
4 .   .   .   x




[TODO.txt](https://github.com/thygolem/Unity3D_2022/blob/main/TODO.txt)
