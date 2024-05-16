namespace HomeWork3_8_3; 
public static class Accountant {
    public static bool AskForBonus(Post worker, int hours) {
        var thresholdHours = (int)worker.Position;
        if (hours > thresholdHours) {
            return true;
        } else {
            return false;
        }
    }
}
