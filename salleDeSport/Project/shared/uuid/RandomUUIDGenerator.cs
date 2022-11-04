public interface IRandomUUIDGenerator {
    public string generateId();
}

public class RandomUUIDGenerator : IRandomUUIDGenerator {
    string IRandomUUIDGenerator.generateId() {
        return Guid.NewGuid().ToString();
    }
    
}