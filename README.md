# Examen final UTN

### Enlaces:

1. [Instrucciones para clonar el proyecto](#clonar-proyecto)
2. [Enlace a las consignas](#consignas)

## Cómo clonar un repositorio, crear una rama y hacer un push

---

<a id="clonar-proyecto"></a>

## Pasos

### 1. Clonar el repositorio

1. Abre una terminal o consola de comandos.
2. Navega al directorio donde deseas clonar el repositorio.
3. Ejecuta el siguiente comando para clonar el repositorio:

```bash
git clone https://github.com/atarico/Final-Prog2
```

4. Cambia al directorio del repositorio clonado:

```bash
cd Final-Prog2
```

### 2. Crear una nueva rama

1. Actualiza el repositorio local con los últimos cambios del remoto (opcional pero recomendado):

```bash
git pull origin main
```

2. Crea una nueva rama con un nombre significativo para tu trabajo:

```bash
git checkout -b <apellido-nombre>
```

Reemplaza <apellido-nombre> con un nombre adecuado.

_Ejemplo:_

```bash
git checkout -b perez-juan
```

3. Realizar cambios y preparar el commit

   - Realiza los cambios necesarios en los archivos del repositorio.

### 3. Verificar agregar, commitear y pushear tus cambios:

1. Verifica el estado de tu proyecto

```bash
git status
```

2. Agrega los archivos modificados o nuevos al área de preparación (staging area):

```bash
git add <archivo> # Para un archivo específico

git add . # Para todos los archivos modificados
```

3. Realiza el commit de tus cambios con un mensaje descriptivo:

```bash
git commit -m "Perez entrega final"
```

4. Hacer un push de la nueva rama al repositorio remoto

```bash
git push -u origin perez-juan
```

---

<a id="consignas"></a>

## En el código hay errores que no dejan que se compile o generan un mal comportamiento del código, tenes que revisarlo y corregirlo.

## En SysTienda:

---

#### 1) Se necesita que las categorías sean opciones que pueda elegir el usuario y no que tenga que tipiarlas

---

#### Cambios a realizar:

1. **Menú de selección para las categorías:**

   1. Crear un método `SeleccionarCategoria` para presentar un menú con las categorías disponibles.
   2. Cuando el usuario ingresa un número para elegir la categoría deseada.
   3. El método valida la entrada y devuelve la categoría seleccionada.

2. **Prevención de errores de entrada:**

   1. Usar int.TryParse para manejar entradas inválidas y evitamos que el programa arroje excepciones si el usuario ingresa un valor no numérico.

3. **Categorías centralizadas:**
   1. Las categorías válidas están definidas en un array categorias, lo que facilita agregar o modificar las categorías en el futuro.

#### Ejemplo:

_Agregar un producto_

El programa solicita el nombre del producto:

```csharp
Nombre: Cappuccino
```

El programa presenta las opciones de categoría:

```csharp
Seleccione una categoría:
1. Libro
2. Café
3. Postre
```

`Ingrese el número: 2`

El usuario selecciona la categoría "Café" ingresando el número 2

El programa continúa

```csharp
Precio: 5.50
Cantidad: 10
Producto agregado exitosamente.
```

---

#### 2) Se necesita que cuando el usuario ingrese EliminarProducto, se muestre una lista de categorías, para poder filtrar los productos, se muestren los productos de la categoría selecionada y se elimine el producto deseado:

---

**_El flujo será el siguiente:_**

1. Mostrar una lista de categorías para que el usuario elija.
2. Filtrar los productos según la categoría seleccionada.
3. Mostrar los productos de esa categoría al usuario.
4. Permitir al usuario elegir un producto por su nombre para eliminarlo.

#### Cambios a realizar:

1. **Método SeleccionarCategoria:**

   1. Permite al usuario seleccionar una categoría de una lista predefinida.
   2. Devuelve la categoría seleccionada como una cadena.

2. **Actualizar EliminarProducto:**
   1. Se filtran los productos según la categoría seleccionada por el usuario.
   2. Muestra una lista numerada de productos en esa categoría.
   3. El usuario selecciona un producto por número para eliminarlo.

#### Ejemplo:

_Inventario:_

```csharp
Libro | 100 años de soledad | $10.00 | 5 unidades
Libro | El Principito | $8.00 | 3 unidades
Café | Capuccino | $4.00 | 10 unidades
Postre | Brownie | $3.50 | 7 unidades
```

Salida al ejecutar EliminarProducto:

```csharp
Selecciona una categoría:
1. Libro
2. Café
3. Postre
```

`Opción: 1`

```csharp
Productos en la categoría Libro:
1. 100 años de soledad | $10.00 | 5 unidades
2. El Principito | $8.00 | 3 unidades
```

`Selecciona el número del producto a eliminar: 2`

```csharp
Producto 'El Principito' eliminado exitosamente.
```

Si no hay productos en la categoría seleccionada:

```csharp
No hay productos en la categoría Postre.
```

---

#### 3) En MostrarInventario se debe incluir las opciones para filtrar el inventario por categoría o mostrar todo el inventario. También ajusté el formato de la salida para que muestre la información como

`Categoría | Nombre | Precio | Cantidad.`

---

#### Cambios a realizar:

1. **Opciones de filtro:**
   El usuario puede elegir entre:

   1. Libro.
   2. Café.
   3. Postre.
   4. Mostrar todo el inventario.

2. **Filtrado por categoría:**

   1. Filtra los productos con LINQ según la opción seleccionada. (de ser posible)

3. **Formato de salida:**

   1. Encabezado que indica las columnas:

      `Categoría | Nombre | Precio | Cantidad.`

4. **Alineación de los datos con formato para una presentación clara.**

   1. ```csharp
      Console.WriteLine($"{producto.Categoria,-10} | {producto.Nombre,-17} | {producto.Precio,8:C} | {producto.Cantidad,8}");
      ```

5. **Control de errores:**
   1. Si no hay productos en la categoría seleccionada, muestra un mensaje apropiado.

### Ejemplo de salida

<i style='text-decoration: underline'>Caso: Mostrar productos de la categoría "Libro"</i>

```csharp
Selecciona una opción:
1. Libro
2. Café
3. Postre
4. Mostrar todo el inventario
```

`Opción: 1`

```csharp
Inventario:
Categoría | Nombre              | Precio   | Cantidad
-----------------------------------------------------
Libro     | 100 años de soledad |   $10.00 |       5
Libro     | El Principito       |   $8.00  |       3
```

<i style='text-decoration: underline'>Caso: Mostrar todo el inventario</i>

```csharp
Selecciona una opción:
1. Libro
2. Café
3. Postre
4. Mostrar todo el inventario
```

`Opción: 4`

```csharp
Inventario:
Categoría | Nombre               | Precio  | Cantidad
----------------------------------------------------
Libro     | 100 años de soledad  |  $10.00 |      5
Libro     | El Principito        |  $8.00  |      3
Café      | Capuccino            |  $4.00  |     10
Postre    | Brownie              |  $3.50  |      7
```

<i style='text-decoration: underline'>Caso: No hay productos en la categoría seleccionada</i>

```csharp
Selecciona una opción:
1. Libro
2. Café
3. Postre
4. Mostrar todo el inventario
```

`Opción: 2`

```csharp
No hay productos disponibles en esta categoría.
```
