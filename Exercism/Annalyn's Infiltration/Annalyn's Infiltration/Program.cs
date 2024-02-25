using System.ComponentModel.Design;

namespace Exercise
{

    public class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            return !knightIsAwake;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            return knightIsAwake || archerIsAwake || prisonerIsAwake;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            return !archerIsAwake && prisonerIsAwake;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool dogIsPresent)
        {
            if (dogIsPresent)
            {
                return !archerIsAwake;
            }
            else
            {
                return (!knightIsAwake && !archerIsAwake && prisonerIsAwake) || (!knightIsAwake && !archerIsAwake && !prisonerIsAwake);
            }
        }
    }




}