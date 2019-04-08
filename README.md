# ArbolBinario

El arbol binario contruido tiene como proposito, mostrar mis conocimientos en c#. La solución cuenta con cuatro proyectos.
1- Business rules: Proyecto donde está la lógica de los arboles
2- TreeApiRest: Proyecto tipo Api donde se puede crear, agregar y buscar el ancestro común a dos nodos
3- UnitTest: Proyecto de prueba unitaria para probar el arbol binario y el método de ancestro
4- Console: Aplicación de prueba para el arbol.


## Usage

Para interactuar con el arbol, se creó un Api rest con 3 Métodos:

Usted podrá hostear la api por medio del IIS Express que brinda el visual studio o puede generar el publish y montarla en un IIS.

Los recursos expuestos por la API son:
1- http://localhost:port/tree/{value} verbo post
Método para crear un arbol con un el root como el 'value' enviado.
2- http://localhost:port/tree/{root}/{node} verbo put
Método para agregar a un arbol un nodo. El arbol se identifica por el root.
3- http://localhost:port/tree/{root}/?node1=76&node2=85 verbo get
Método para buscar el ancestro de dos nodos enviados para un arbol en específico.
Tiene dos parámetros llamados node1 y node2 que se envían por query string.

Por otro lado, la solución de visual studio tiene un proyecto exclusivo de testing. Este realiza la prueba unitaria para el método ancertor y los valores dados en la prueba.


## License
Fabian Ruiz
