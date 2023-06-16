# UTN_Programacion_Avanzada_I
Repository to upload work done during the Advanced Programming 1 course at UTN


8) ¿Qué es el IL?
Se refiere al Intermediate Language, un lenguaje de código intermedio. Existe para llevar el código de alto nivel a esta capa intermedia con el fin de poder ejecutar código de otros lenguajes de alto nivel.
Este código intermedio es el que será luego llevado a código nativo para su ejecución.

9) Explique con sus palabras VES, CTS y CLS.
VES, es el entorno de .NET donde se ejecuta código de manera segura y administrada.
CTS, es el componente que se encarga de la conveción de los tipos en los lenguajes, de manera que la interacción entre los distintos lenguajes sea exitosa.
CLS, es el conjunto de reglas que garantizan que los programas escritos en distintos lenguajes puedan interactuar entre sí al asegurar la compatibilidad entre estos.

10) Explique con sus palabras que es un Assembly, el early y late Binding.
Un Assembly es un archivo que contiene código compilado de manera que sirva como un conjunto de recursos reutilizables por otros programas o bibliotecas.
Early binding y Late binding hacen referencia a la manera o a cuándo el compilador entiende lo que hace un método. En early binding se entiende lo que hace el método al momento de compilar el código. En cambio, en late binding el programa se da cuenta de lo que hace un método en el momento de la ejecución, como ocurre al aplicar inversión de dependencia con una interface.

11) ¿Qué es GIT? ¿Es centralizado o distribuido? Ejemplifique al menos 3 comandos de
git y explique su funcionamiento.
Git es un sistema de control de versiones. Es distribuido porque el repositorio se distribuye entre varias máquinas, de manera que si se pierde la info en una parte, este puede ser restaurado desde alguna de las máquinas que guarde una copia reciente del repositorio.

Comandos:
git checkout -b <nombre_de_rama>: se usa para crear una rama nueva y moverse hacia ella.
git commit -m "<mensaje>": se utiliza para formalizar el guardado del código que se encuentra en stage, generando con esto una nueva versión del código. El -m es para agregarle un mensaje explicativo del commit.
git fetch: se utiliza para actualizar los metadatos del repositorio local con los que están en el repositorio remoto, sin traerse los archivos.