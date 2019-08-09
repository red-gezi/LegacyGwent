using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
    [CardEffectId("44014")]//加强型弩炮
    public class ReinforcedBallista : CardEffect
    {//对1个敌军单位造成2点伤害。 驱动：再次触发此能力。
        public ReinforcedBallista(GameCard card) : base(card) { }
        public override async Task<int> CardPlayEffect(bool isSpying, bool isReveal)
        {
            var selectList = await Game.GetSelectPlaceCards(Card, selectMode: SelectModeType.EnemyRow);
            if (!selectList.TrySingle(out var target))
            {
                return 0;
            }
            await target.Effect.Damage(2, Card);
            return 0;
        }
    }
}