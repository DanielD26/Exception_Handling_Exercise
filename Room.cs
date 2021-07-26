namespace Exception_Handling_Exercise {
    public class Room {
        public string Code {get; set;}
        public string Name {get; set;}
        public System.DateTime DateEntered {get; set;}

        public string TimeEntered {get; set;}
        public int Time {get; set;}

        public Room (string code, string name, System.DateTime dateEntered, string timeEntered, int time) {
            this.Code = code;
            this.Name = name;
            this.DateEntered = dateEntered;
            this.TimeEntered = timeEntered;
            this.Time = time;
        }
    
    }

}