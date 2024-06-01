using BinDI;

[SubscribeTo(typeof( IncrementLocalCountOperation ))]
public sealed class IncrementLocalCountButton : SubscribableButton { }