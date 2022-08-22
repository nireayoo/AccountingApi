namespace AccountingApp.Helpers
{
    //this folder is similar to the appsettings.json file except that the program cannot directly interact interact with json
    //so we need a file to access application settings via dependency injection(objects injected in a constructor)
    public class AppSettings
    {
        public string Secret { get; set; }
        //the secret code in the jwt
    }
}
