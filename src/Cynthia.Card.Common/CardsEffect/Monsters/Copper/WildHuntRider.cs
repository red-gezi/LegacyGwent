using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("24005")]//狂猎骑士
	public class WildHuntRider : CardEffect
	{//使对方同排的“刺骨冰霜”伤害提高1点。
		public WildHuntRider(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardPlayEffect(bool isSpying)
		{
			return 0;
		}
	}
}