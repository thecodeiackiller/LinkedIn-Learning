using System.Text.Json;

namespace SendingNewsletters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int count = numbers.Count();

            // INSTRUCTION: Write a C# function that searches as JSON payload for a specific property
            // QUESTION: What are "properties" in JSON?
            // SCENARIO: We have a newsletter subscription service where the JSON Data has some meta information and a list of subscribers.
            // QUESTION: What is meta information in simple terms?

            // QUESTION: What is a JSON "Payload?"

            // FUNCTION
            // Going to INPUT a string value (which is the json)
            // Going to OUTPUT a LIST of integers that represent the ID property of any subscribers that don't have an email

            // CRITERIA
            // We want to operation to happen as fast as possible.
            // We want this to be read only.
            // This mean we need a the fastest solution that allows us to access to data and read it
            //
            // In addition, we want to do this without serializing the data into an object first.

            // QUESTION: What does serialization mean when working with JSON, XML, YAML, etc.?
            // 
            // Here is the process of Serialization. Serialization is when we convert a .NET object into a string.
            Subscriber prototypeSubscriber = new Subscriber()
            {
                Id = 1,
                FirstName = "Ted",
                LastName = "Nunn",
                Email = "ted.nunn@candyrific.org"
            };

            string jsonSerializeString = JsonSerializer.Serialize(prototypeSubscriber);
            // We can see the effects of the serialization through the view port in the debugger

            // QUESTION: What the heck does JSON and C# have to do with one another?
            //
            // POINT: An object in C# is an instance that encapsulated state and behavior. You want to convert JSON to an Object (Deserialization) so that you can work with the JSON data in your app
            // QUESTION: All applications deal with objects. Why can't we just compare objects to objects?
            // POINT: 85% of the internet revolved around APIs.
            // POINT: The newtonsoft.json library and System.text.json namespace provide methods and serialize and deserialize



            string jsonString = @"
        {

            ""subscribers"": [
                { ""id"": 1, ""email"": ""alice@example.com"" }, 
                { ""id"": 2, ""email"": null }
            ]
        }";

            // QUESTION: What is a JSON Property?
            // QUESTION: What is meant by the JSON root element?
            // QUESTION: Why are there double double quotes?
            // NOTE: Each JSON property key is a string. The property value can be anything.

            // POINT: Using statement to ensure proper disposal of JsonDocument
            // POINT: We have to use using before because JsonDocument implements IDisposable, preventing memory leaks. 
            // POINT: We could have used either JsonDocument or JsonNode (We chose JsonDocument because of the criteria to make the sorting as fast as possible.

            // QUESTION: What's the difference between JsonDocument and JsonNode?
            // QUESTION: How do we access values in a JSON payload between JsonNode and JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                // Work with the JsonDocument here
                JsonElement root = doc.RootElement;
                Console.WriteLine("The following subscribers do not have an email:");
                foreach (JsonElement subscriber in root.GetProperty("subscribers").EnumerateArray())
                {
                    // 
                    if(subscriber.GetProperty("email").ValueKind == JsonValueKind.Null)
                        // QUESTION: Why do we have to use ValueKind to compare the Json properties to null
                        // ANSWER: JSON Elements are structs and in .NET, structs are value types, and in .NET, value types cannot be null.
                    {
                        Console.WriteLine($"Subscriber ID: {subscriber.GetProperty("id").GetInt32()}");
                    }
                    
                }
            } // NOTE: At this point, doc.Dispose() is called automatically This is because JsonDocument implements IDisposable interface.
        }
        
        

    }
}
