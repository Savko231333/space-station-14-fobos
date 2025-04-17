using Content.Shared.FixedPoint;
using Robust.Shared.Prototypes;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Audio;
using Content.Shared.Damage;

namespace Content.Server.DeadSpace.Censer;

[RegisterComponent]
public sealed partial class CenserComponent : Component
{
    [DataField]
    public string SolutionName = "Censer";
    [DataField]
    public ProtoId<ReagentPrototype> Reagent = "Holywater";

    [DataField, AutoNetworkedField]
    public FixedPoint2 Consumption = FixedPoint2.New(50.0f);

    [DataField]
    public TimeSpan UsingDelay = TimeSpan.FromSeconds(15.0);

    [DataField("heailng", required: true)]
    [ViewVariables(VVAccess.ReadWrite)]
    public DamageSpecifier Damage = default!;
}