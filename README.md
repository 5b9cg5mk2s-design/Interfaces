# Laboratorio Interfaces

**Fecha:** 11/10/2026

## Contenido del Repositorio

ste laboratorio consiste en el desarrollo de una aplicación de escritorio en Windows Forms para la gestión de productos. La aplicación permite registrar productos mediante un formulario que valida los datos ingresados por el usuario antes de almacenarlos en memoria.

Se implementó el uso de interfaces y clases para aplicar el principio de separación de responsabilidades, utilizando validadores específicos para cada tipo de dato (texto, decimal y entero). Además, los productos registrados se muestran dinámicamente en una tabla mediante un DataGridView.

## Tecnologías Utilizadas

- Lenguaje: C#
- Framework: Windows Forms (.NET Framework)
- Colecciones Genéricas (List<T>)
- Programación Orientada a Objetos (POO)
- Interfaces
- Herramientas: Visual Studio, Git, GitHub

## Capturas de Pantalla y Problemas

### Interfaz Principal

<img width="748" height="497" alt="image" src="https://github.com/user-attachments/assets/9f545fdf-e8bd-45ec-9b25-2c3c93c2962c" />

### Ejercicio 1: Registro de Productos

**Descripción:**

Se desarrolló un formulario que permite ingresar el nombre, precio y cantidad de un producto. Una vez validados los datos, el producto se almacena en una lista interna de objetos y se muestra automáticamente en una tabla de datos.

<img width="760" height="480" alt="image" src="https://github.com/user-attachments/assets/5b5b37c7-6de1-41fb-b1d1-67a1f93f2ff0" />

### Ejercicio 2: Validación de Campos

**Descripción:**

Se implementó un sistema de validación utilizando una interfaz llamada `IValidadorCampo`, permitiendo crear validadores independientes para cada tipo de dato requerido por el formulario.

Las validaciones aplicadas son:

- Nombre del producto obligatorio.
- Precio numérico decimal válido.
- Cantidad numérica entera válida.
- Restricción de valores negativos.
- Mensajes de error mostrados mediante `ErrorProvider`.

<img width="744" height="487" alt="image" src="https://github.com/user-attachments/assets/10eb0523-f924-480e-822b-cc9b14d6f653" />

### Ejercicio 3: Visualización de Datos

**Descripción:**

Los productos registrados son mostrados en un `DataGridView`, el cual se actualiza automáticamente cada vez que se agrega un nuevo producto. La tabla ajusta sus columnas para aprovechar mejor el espacio disponible dentro del formulario.

<img width="744" height="486" alt="image" src="https://github.com/user-attachments/assets/dfed44c2-25aa-4458-adcc-0915b9d64cbc" />

## Estructura de Carpetas o Directorios

```plaintext
ProyectoProductos/
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Validadores.cs
├── Properties/
│
└── README.md
```

### Descripción de los Archivos

- **Form1.cs:** Contiene la lógica principal del formulario.
- **Validadores.cs:** Define la interfaz de validación, los validadores específicos y la clase Producto.
- **Program.cs:** Punto de entrada de la aplicación.
- **Properties:** Archivos de configuración del proyecto.

## Instrucciones de Ejecución / Uso

### 1. Clonar el repositorio

```bash
git clone https://github.com/usuario/ProyectoProductos.git
```

### 2. Abrir el proyecto

Abrir la solución en Visual Studio.

### 3. Compilar la aplicación

Seleccionar:

```plaintext
Build → Build Solution
```

### 4. Ejecutar

Presionar:

```plaintext
F5
```

o seleccionar:

```plaintext
Debug → Start Debugging
```

### 5. Registrar productos

1. Ingresar el nombre del producto.
2. Ingresar el precio.
3. Ingresar la cantidad.
4. Presionar el botón **Guardar**.
5. Verificar que el producto aparezca en la tabla.

## Conceptos Aplicados

### Interfaces

Se utilizó la interfaz `IValidadorCampo` para definir un contrato común para todas las validaciones.

### Polimorfismo

Los validadores (`ValidadorTexto`, `ValidadorDecimal` y `ValidadorEntero`) implementan la misma interfaz permitiendo tratarlos de forma uniforme.

### Encapsulamiento

Cada validador contiene su propia lógica de validación y mensaje de error.

### Programación Orientada a Objetos

Se creó la clase `Producto` para representar y almacenar la información de cada producto registrado.

## Autor y Contexto

- Nombre: Johandry González
- Institución: Universidad Tecnológica de Panamá (UTP)
- Curso: Herramientas de programación aplicadas III
- Fecha de Realización: 11/10/2026

## Referencias

- Documentación proporcionada por el docente.
