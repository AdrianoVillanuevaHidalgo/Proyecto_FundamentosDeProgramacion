# Sistema de Gestión Vehicular - UPN

**Descripción:**  
Sistema de escritorio desarrollado en **C# (Windows Forms)** bajo el paradigma de Programación Orientada a Objetos (POO) y una arquitectura modular de 3 capas. Este software permite registrar, consultar y organizar el ingreso de vehículos al estacionamiento (Pabellón D), gestionando el control de aforo (50 vacantes) mediante el uso de listas dinámicas (`List<Vehiculo>`).

## 🛠Tecnologías Utilizadas
* **Lenguaje:** C# 
* **Framework:** .NET Framework 4.7.2
* **Entorno de Desarrollo:** Microsoft Visual Studio
* **Control de Versiones:** Git y GitHub
* **Diseño Algorítmico:** PSeInt (Pseudocódigo y Diagramas de Flujo)

## ⚙Funcionalidades Principales
1. **Control de Registro y Aforo:** Ingreso de datos del vehículo y cálculo en tiempo real de los espacios disponibles en el estacionamiento.
2. **Búsqueda Lineal:** Módulo de consulta que recorre la lista dinámica para localizar un vehículo específico mediante su placa.
3. **Ordenamiento Burbuja (Bubble Sort):** Algoritmo implementado para ordenar alfabéticamente los registros según la placa vehicular.
4. **Validación de Datos:** Uso de expresiones regulares y validaciones lógicas para evitar campos vacíos o formatos de placa incorrectos.

## Estructura del Proyecto (Arquitectura en 3 Capas)
```text
📁 GestionVehicular (Solución)
 ┣ GestionVehicular.slnx
 ┣ .gitignore
 ┗ 📁 GestionVehicular (Proyecto)
    ┣ App.config
    ┣ GestionVehicular.csproj
    ┣ Program.cs
    ┃
    ┣ 📁 Clases
    ┃  ┣ GestionVehiculos.cs
    ┃  ┣ Validaciones.cs
    ┃  ┗ Vehiculo.cs
    ┃
    ┣ 📁 Formulario
    ┃  ┣ Form1.cs
    ┃  ┣ Form1.Designer.cs
    ┃  ┗ Form1.resx
    ┃
    ┣ 📁 Properties
    ┃  ┣ AssemblyInfo.cs
    ┃  ┣ Resources.Designer.cs
    ┃  ┣ Resources.resx
    ┃  ┣ Settings.Designer.cs
    ┃  ┗ Settings.settings
    ┃
    ┗ 📁 Resources
       ┣ Pegar-20.png
       ┣ actualizar-20.png
       ┣ bote-de-basura-20.png
       ┗ lapiz-20.png
```

---
*Proyecto desarrollado para el curso de Fundamentos de Programación - Universidad Privada del Norte (UPN) - 2026.*