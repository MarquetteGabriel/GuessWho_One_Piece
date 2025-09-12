using GuessWhoOnePiece.Services;

namespace GuessWhoOnePiece.Tests.Services
{
    public class IndexMenuServiceTest
    {
        [Fact]
        public void Test_IndexMenuService()
        {
            var IM = new IndexMenuService();
            IM.IndexMenu = Model.IndexMenuTabBar.Settings;
            Assert.Equal(Model.IndexMenuTabBar.Settings, IM.IndexMenu);

            IM.IndexMenu = Model.IndexMenuTabBar.Game;
            Assert.Equal(Model.IndexMenuTabBar.Game, IM.IndexMenu);

            IM.IndexMenu = Model.IndexMenuTabBar.Characters;
            Assert.Equal(Model.IndexMenuTabBar.Characters, IM.IndexMenu);
        }
    }
}
