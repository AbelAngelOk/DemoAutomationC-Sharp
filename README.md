# DemoAutomation-OrangeHRM

**Sobre el proyecto:** es una de mostracion de un proyecto de automatizacion de casos de prueba. Puede descargarse y correr los tests desde el "explorador de pruebas" o de forma individual sobre la cabecera del test.

**Detalles tecnicos**
- Lenguaje: C#
- patron de diseño: screenplay.

**Librerias principales**
- **Nunit** para gestion de pruebas.
- **Selenium** para interactuar con la web.
- **Boa.Constrictor** para aplicar el patron screenplay.
- **Fluent.Assertions** para aplicar asserts con formato screenplay.

**Carpetas**
- **Tests** contiene los tests divididos por suites de pruebas.
- **Pages** contiene los localizadores de los elementos web.
- **Interactions** contiene las interacciones del actor con la web. Equivalente a pasos de prueba.
- **Models** modelos de datos.

**modo de uso**
- ingresar a *DemoAutomation.sln* para abrir el proyecto
- desplegar seccion *ver* y abrir *explorador de pruebas* para gestionar los casos de prueba.
- ingresar a la carpeta *Tests* y seleccionar una clase (suite de prueba) para visualizar los casos de prueba de dicha suite.
