Create a program named *PaintingDemo* that instantiates an array of eight `Room` objects and demonstrates the `Room` methods. 

The `Room` constructor requires parameters for length, width, and height fields (all of type `int`); use a variety of values when constructing the objects. 

The `Room` class also contains the following fields:
* `Area` - The wall area of the `Room` (as an `int`)
* `Gallons` - The number of gallons of paint needed to paint the room (as an `int`)

Both of these values are computed by calling `private` methods. Include read-only properties to get a `Room`’s values. 

A room is assumed to have four walls, and you do not need to allow for windows and doors, and you do not need to allow for painting the ceiling. A room requires one gallon of paint for every 350 square feet (plus an extra gallon for any square feet greater than 350). In other words, a 12 x 3 x 10 room with 9-foot ceilings has 396 square feet of wall space, and so requires two gallons of paint.


