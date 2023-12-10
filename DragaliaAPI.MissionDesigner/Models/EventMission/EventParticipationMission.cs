namespace DragaliaAPI.MissionDesigner.Models.EventMission;

public class EventParticipationMission : Mission
{
    protected override MissionCompleteType CompleteType => MissionCompleteType.EventParticipation;

    public required int EventId { get; init; }

    protected override int? Parameter => this.EventId;
}
