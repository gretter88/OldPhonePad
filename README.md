# OldPhonePad

Desafío de codificación C# de Iron Software

##  Descripción

Se presenta un teclado de teléfono clásico con botones numéricos que representan letras. Cada número puede ser presionado varias veces para acceder a diferentes letras. Además, se incluye una tecla de retroceso ('*'), un espacio (' '), y un botón de envío ('#'), que marca el final de la entrada.

### Reglas:
- Presionar un número varias veces cambia la letra que se selecciona.
- Una pausa de 1 segundo (representada por un espacio '" "') permite escribir dos caracteres consecutivos usando la misma tecla.
- El carácter '*' elimina el último carácter ingresado.
- El carácter '#' indica el final de la entrada.

---

## Ejemplos

| Entrada                        | Salida |
|-------------------------------|--------|
| "33#"                         | E      |
| "227*#"                       | B      |
| "4433555 555666#"             | HELLO  |
| "8 88777444666*664#"          | TOO    |

---

## Estructura del Proyecto

- OldPhonePad.cs: Clase principal que contiene el método `OldPhonePad(string input)` encargado de realizar la conversión.
- OldPhonePadTests.cs: Casos de prueba unitarios usando NUnit.
- README.md: Documentación del proyecto.

---

 Cómo ejecutar los tests

Este proyecto utiliza NUnit para pruebas unitarias. Para ejecutarlas:

1. Abrí el proyecto en Visual Studio.
2. Asegurate de tener instalado el paquete NUnit y NUnit3TestAdapter.
3. Ejecutá los tests desde el Test Explorer.

---

## Autor

Proyecto realizado como prueba técnica.  
Usuario de GitHub: [@gretter88](https://github.com/gretter88)

---

## Fecha

Abril 2025
