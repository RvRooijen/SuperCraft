# Waarom public of private

public int Leeftijd = 8; // Andere classes mogen hier bij  
private int leeftijd = 8; // Hier mogen andere classes niet bij

# Classes

Objecten in onze wereld ( poppetjes, blokjes en obstakels )

```csharp
public class Poppetje  
{

}
```

# Functions
Wat is een function
Wat de class allemaal kan doen ( Het poppetje loopt of schiet )

```csharp
public class Poppetje
{
    // Wie kan er bij Wat geeft het terug Naam
    public void Lopen()
    {
        // Hier komt de code als deze functie word aangeroepen
    }
}
```

```csharp
public class Blokje
{
    public Poppetje OnsPoppetje;
    
    // Als we een functie maken die Start heet met een hoofdletter S dan roept Unity die aan zodra het spel start.
    public void Start()
    {
        OnsPoppetje.Lopen();
    }
}
```

# Variables
Wat is een variable
In een variale bewaren we informatie

Private variables schrijven we met een kleine letter aan het begin.
Public variables schrijven we met een hoofdletter aan het begin.

### Hoe maken we een nieuwe variable

1. public of private
2. Type van de variable bijvoorbeeld een string of een Poppetje
3. De naam van de nieuwe variable
4. Als we er een waarde aan willen geven kunnen we dit doen met =
5. Vul de waarde in van de variable bijvoorbeeld "Hallo"
6. Sluit de regel af met ;

```csharp
public string Naam = "Hallo";
```

Wat voor type variables zijn er

```csharp
Float - getallen met komma  
Int - volledige getallen  
Bool - ja of nee  
String - namen/letters, om de text zetten we een "" teken heen. Bijvoorbeeld "Hallo"
```

# Variables aanpassen

```csharp
public int Leeftijd = 1;

// -- is eentje omlaag
// ++ is eentje omhoog

// Als Leeftijd 1 was dan is Leeftijd 0 nadat we deze code uitvoeren
Leeftijd--;

// Als Leeftijd 1 was dan is Leeftijd 2 nadat we deze code uitvoeren
Leeftijd++;
```
```csharp
Leeftijd += 5; // De leeftijd gaat met 5 omhoog en is dus 6
```

# Als dan
Vergelijken van variables

```csharp
if(//Hier komt de vergelijking)
{
    // Hier komt de code als de vergelijking waar is
}

private int leeftijd = 8;

if (Leeftijd > 8)
{
    // Als de leeftijd hoger is dan 8 komt de code hier
}

if (Leeftijd < 8)
{
    // Als de leeftijd lager is dan 8 komt de code hier
}

if (Leeftijd == 8)
{
    // Als de leeftijd gelijk is aan 8 komt de code hier
}

if (Leeftijd != 8)
{
    // Als de leeftijd niet gelijk is aan 8 komt de code hier
}
```