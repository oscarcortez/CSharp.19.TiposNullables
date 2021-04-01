# CSharp.19.TiposNullables

crear un tipo nullable, despues del tipo se debe agregar ?
```csharp
int? enteroNulo = null;
```

un tipo no nullable: 
```csharp
int enteroNormal = 0;
```
y un tipo nullable
```csharp
int? enteroNulo = null;
```

no pueden asignarse directamente:
```csharp
enteroNormal = enteroNulo; // bad
```

pero si se puede asignar de esta manera:
```csharp
enteroNormal = enteroNulo.Value;
```
