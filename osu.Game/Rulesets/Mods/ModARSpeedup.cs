using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects;

public class ModARSpeedup : Mod, IApplicableToBeatmap
{
    public override string Name => "Per Note AR";
    public override string Acronym => "PNAR";
    public override ModType Type => ModType.DifficultyIncrease;
    public override double ScoreMultiplier => 2.0;
    public override bool Ranked => base.Ranked;
    public override LocalisableString Description => "Arrr";

    public void ApplyToBeatmap(IBeatmap beatmap)
    {
        /*foreach (var hitObject in beatmap.HitObjects)
        {
            // Генеруємо випадковий AR для кожної ноти (наприклад, від 0 до 10)
            double desiredAR = new System.Random().NextDouble() * 10;

            // Отримуємо час появи ноти
            double time = hitObject.StartTime;

            // Створюємо новий контрольний пункт складності
            var difficultyPoint = new DifficultyControlPoint
            {
                ApproachRate = desiredAR,
                // Зберігаємо інші параметри (наприклад, CircleSize) без змін
                CircleSize = beatmap.ControlPointInfo.DifficultyPointAt(time)?.CircleSize
            };

            // Додаємо контрольний пункт до мапи
            beatmap.ControlPointInfo.Add(time, difficultyPoint);
        }*/
    }
}
