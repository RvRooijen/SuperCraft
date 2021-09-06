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

Wat voor type variables zijn er

```csharp
Float - getallen met komma  
Int - volledige getallen  
Bool - ja of nee  
String - namen/letters  
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

if (Leeftijd > 8)
{
    // Als de leeftijd hoger is dan 8 komt de code hier
}

// == is gelijk aan
// != is niet gelijk aan
```