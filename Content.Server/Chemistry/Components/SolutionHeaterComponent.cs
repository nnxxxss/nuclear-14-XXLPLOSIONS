namespace Content.Server.Chemistry.Components;

[RegisterComponent]
public sealed partial class SolutionHeaterComponent : Component
{
    /// <summary>
    ///     How much heat is added per second to the solution, with no upgrades.
    /// </summary>
    [DataField]
    public float BaseHeatPerSecond = 120;

    /// <summary>
    ///     How much heat is added per second to the solution, taking upgrades into account.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float HeatPerSecond;

    /// <summary>
    ///     The machine part that affects the heat multiplier.
    /// </summary>
    [DataField]
    public string MachinePartHeatMultiplier = "Capacitor";

    /// <summary>
    ///     How much each upgrade multiplies the heat by.
    /// </summary>
    [DataField]
    public float PartRatingHeatMultiplier = 1.5f;
}
