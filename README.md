# Datastructuren en algoritmen

Dit is een inleiding in **datastructuren** en de bijhorende **algoritmen**.

# In de vorige branches

- Gebruik van een `System.Collections.Stack` + analyse van de exception bij aanroepen van `Pop()` bij een lege Stack.
- Gebruik van een `System.Collections.Queue` + exception bij aanroepen van `Dequeue()` bij een lege Queue.
- Gebruik van een `System.Collection.Generic.Queue<T>` met `T` als `string`
- Gebruik van een `System.Collections.Generic.List<T>`

# In deze branch

- Maken van een eigen datastructuur `MyCustomCollection` op basis van `List<string>`:
  - met de methods:
	  - `Append(string element)` : voeg toe op het einde
	  - `Prepend(string element)` : voeg toe aan het begin
	  - `Clear()` : wis alle elementen
	  - `First()` : returnt het eerste element en verwijderd het
	  - `Last()` : return het laatste element en verwijderd het
  - met de property:
	  - `Count` : returnt het aantal elementen

- Eventueel kunnen we een indexer implementeren om de elementen via index te benaderen:
  - `[]` : index-operator

- Om backwards compatibiliteit te hebben, kunnen we **overwegen** om deze methods ook te implementeren:
  - `Pop()` : return en verwijder het eerste element
  - `Push()` : alias voor `Prepend()`
  - `Enqueue()` : alias voor `Prepend()`
  - `Dequeue()` : return en verwijder het laatste element

