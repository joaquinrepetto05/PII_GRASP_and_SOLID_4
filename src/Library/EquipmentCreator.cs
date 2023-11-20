namespace Recipies
{
    public class EquipmentCreator
    {
        public static Equipment CreateEquipment(string description, double hourlyCost)
        {
            return new Equipment(description, hourlyCost);
        }
    }
}