Create an application named `ShapesDemo` that creates several objects that descend from an abstract class called `GeometricFigure`. Each `GeometricFigure` includes a `height`, a `width`, and an `area`. Make sure the constructors are in the take in the `height`, then `width` as `int`.

Provide `get` and `set` accessors for each field except `area`; the `area` is computed and is read-only. Include an abstract method called `ComputeArea()` that computes the area of the `GeometricFigure`. 

Next you will create three additional classes derived from the `GeometricFigure` class. Name these derived classes: `Rectange`, `Square`, and `Triangle`. 
