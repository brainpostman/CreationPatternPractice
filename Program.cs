using CreationPatternPractice;

var flat = new Flat("Moscow", "Lenin", 12, 10, "Russia", 40, 2);
var flat2 = flat.Clone();

var penthouse = new Penthouse(2, "Moscow", "Lenin", 1, 40, "Russia", 400, 10);
var penthouse2 = penthouse.Clone();

var underpass = new Underpass(1, "Russia", 100, 30);
var underpass2 = underpass.Clone();