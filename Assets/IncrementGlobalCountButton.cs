using BinDI;

[SubscribeTo(typeof( IncrementGlobalCountOperation ))]
public sealed class IncrementGlobalCountButton : SubscribableButton { }