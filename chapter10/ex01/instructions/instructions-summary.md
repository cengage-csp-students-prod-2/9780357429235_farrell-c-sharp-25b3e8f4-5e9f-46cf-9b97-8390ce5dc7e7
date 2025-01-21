Create an application `class` named `LetterDemo` that instantiates objects of two classes named `Letter` and `CertifiedLetter` and that demonstrates all their methods. 

The classes are used by a company to keep track of letters they mail to clients. The `Letter` `class` includes auto-implemented properties for the `Name` of the recipient and the `Date` mailed (stored as strings). 

Create a child `class` named `CertifiedLetter` that includes an auto-implemented property `TrackingNumber` (of type `string`) that holds a tracking number for the letter.

Next, include a `ToString()` method that overrides the Object class’s `ToString()` method and returns a `string` that contains the name of the class (using `GetType()`) and the respective class's data field values. Use default, empty constructor for both classes.
