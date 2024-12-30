# Uninitialized Property Access in C#

This code demonstrates a potential issue in C# related to accessing properties that have not been explicitly initialized.  While C# provides default values (0 for integers, null for reference types, etc.), this behavior may not always be what the developer intends, potentially leading to unexpected behavior or runtime errors if a specific initial value is required.

The `bug.cs` file showcases a simple example where the `MyProperty` is accessed before any value is assigned. The `bugSolution.cs` file provides a potential fix by explicitly initializing the property.