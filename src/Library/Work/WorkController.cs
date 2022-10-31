namespace Library;

public sealed class WorkController{

    public static WorkController s;
        private WorkController (){}
        public static WorkController GetInstance()
        {
            if (s==null)
            {
                s = new WorkController();
            }
            return s;
        }
  
    private List<Work> workList = new List<Work>();
    private int id;

    public int getId(){
        return this.id;
    }

    public void AddWork(Offer myOffer, Employer myEmployer){
        Work myWork = new Work(myOffer, myEmployer, workList.Count()+1);

        this.workList.Add(myWork);
    }

    public void RemoveWork(Work myWork){
        this.workList.Remove(myWork);
    }

    public List<Work> ListWorks(){
        return this.workList;
    }

    public List<Work> ListWorkerWorks(int myId){
        List<Work> workerList = new List<Work>();
        foreach (var work in this.workList)
        {
            if(work.GetEmployer().getId() == myId){
                workerList.Add(work);
            }
        }

        return workerList;
    }

}