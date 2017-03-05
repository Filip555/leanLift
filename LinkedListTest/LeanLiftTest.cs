using System;
using Xunit;
using LinkedList;
using System.Linq;

namespace LinkedListTest
{
    public class LeanLiftTest
    {
        LinkedListClass listOfElementsTosendToLeanLift = new LinkedListClass();
        public LeanLiftTest()
        {
            listOfElementsTosendToLeanLift.SaveElementToLinkedList("G000");
            listOfElementsTosendToLeanLift.SaveElementToLinkedList("G001");
            listOfElementsTosendToLeanLift.SaveElementToLinkedList("P/G002");
            listOfElementsTosendToLeanLift.SaveElementToLinkedList("G003");
            listOfElementsTosendToLeanLift.SaveElementToLinkedList("G004");
        }
        [Fact]
        public void FirstElementShouldBePG002()
        {
            var result = listOfElementsTosendToLeanLift.list.First.Value;

            Assert.Equal(result, "P/G002");
        }
        [Fact]
        public void LastElementShouldBeG004()
        {
            var result = listOfElementsTosendToLeanLift.list.Last.Value;

            Assert.Equal(result, "G004");
        }
        [Fact]
        public void CountOfErrorShouldBeFive()
        {
            listOfElementsTosendToLeanLift.SendComunicate();
            var result = listOfElementsTosendToLeanLift.listWithErrors.Count;

            Assert.Equal(result, 5);
        }
        [Fact]
        public void AfterSendAllListToLeanAndLeanReturnError99ForEveryThingProgramShouldReloadListAndFirstElementShouldBePG002()
        {
            listOfElementsTosendToLeanLift.SendComunicate();
            var result = listOfElementsTosendToLeanLift.listWithErrors;

            foreach (var item in result)
            {
                listOfElementsTosendToLeanLift.SaveElementToLinkedList(item);
            }
            Assert.Equal(listOfElementsTosendToLeanLift.list.First.Value, "P/G002");
        }
    }
}
