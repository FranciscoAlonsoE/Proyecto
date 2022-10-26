namespace Library;

public sealed class WorkController{

  
    private List<Work> workList = new List<Work>();
    private int id;

    public int getId(){
        return this.id;
    }

    public void AddWork(Offer myOffer, Worker myWorker){
        Work myWork = new Work(myOffer, myWorker, workList.Count()+1);

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
            if(work.getWorker().getId() == myId){
                workerList.Add(work);
            }
        }

        return workerList;
    }

}