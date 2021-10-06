using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LUTGCaster.UnitTests
{
    [TestFixture]
    class ShowTests
    {
        [SetUp]
        public void SetUp()
		{
            s_show = new Show(s_name);
            s_role = new Role(s_rName);
            s_emptyNames = Enumerable.Repeat("", 6).ToList();
		}

        #region Constructor Tests

        [Test]
        public void Constructor_ShouldInitialiseProperties()
        {
            s_show = new Show(s_name);

            Assert.Multiple(() =>
            {
                Assert.That(s_show.name, Is.EqualTo(s_name));
                Assert.That(s_show.roles, Is.InstanceOf<List<Role>>());
                Assert.That(s_show.roles, Is.Empty);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Constructor_ShouldThrowArgumentNullException_WhenGivenNullOrWhiteSpaceName(string name)
		{
            Assert.That(() => new Show(name), Throws.InstanceOf<ArgumentNullException>());
		}

        #endregion

        #region AddRole Tests

        [Test]
        public void AddRole_ShouldCreateAndAddANewRoleToRoles()
		{
            s_show.AddRole(s_rName);

            Assert.Multiple(() =>
            {
                Assert.That(s_show.roles[0].rName, Is.EqualTo(s_rName));
                Assert.That(s_show.roles[0].names, Is.EquivalentTo(s_emptyNames));
            });
            
		}

        [Test]
        public void AddRole_ShouldthrowArgumentNullException_WhenGivenNullName()
		{
            Assert.That(() => s_show.AddRole(null), Throws.InstanceOf<ArgumentNullException>());
        }

        #endregion

        #region Member Variables

        private Show s_show;
        private Role s_role;
        private List<string> s_emptyNames;
        private const string s_name = "a name";
        private const string s_rName = "role name";

        #endregion
    }
}
