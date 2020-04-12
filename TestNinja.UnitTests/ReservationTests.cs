using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancellingTheReservation_ReturnsTrue()
        {
            //Arrange 
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert            
            Assert.That(result, Is.True);
            /*
                -Tb pode ser assim:
                    -Assert.IsTrue(result);
                    -Assert.That(result == true);
            */
        }

        [Test]
        public void CanBeCancelledBy_NonAdminUserCancellingTheReservation_ReturnsFalse()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            Assert.IsFalse(result);            
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User() { IsAdmin = true };
            var reservation = new Reservation() { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_DifferentUserCancellingTheReservation_ReturnsFalse()
        {
            var user = new User() { IsAdmin = true };
            var reservation = new Reservation() { MadeBy = user };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
