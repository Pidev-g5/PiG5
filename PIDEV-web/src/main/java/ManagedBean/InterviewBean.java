package ManagedBean;

import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import javax.ejb.EJB;
import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.context.FacesContext;

import model.Fixed;
import model.Interview;
import model.Person;
import model.Reserved;
import services.FixedService;
import services.InterviewService;
import services.PersonService;
import services.ReservedService;

@ManagedBean (name = "interviewBean") 
@SessionScoped
public class InterviewBean implements Serializable {
	private static final long serialVersionUID = 1L;
	private int interviewId;
	private int reservedId;
	private int capacity;
	private Date date;
	public Date newDate;
	public int SelectedDateTobeUpdated;
	public int SelectedCapacityTobeUpdated;
	public int getSelectedCapacityTobeUpdated() {
		return SelectedCapacityTobeUpdated;
	}
	public void setSelectedCapacityTobeUpdated(int selectedCapacityTobeUpdated) {
		SelectedCapacityTobeUpdated = selectedCapacityTobeUpdated;
	}
	public int getSelectedReservedById() {
		return selectedReservedById;
	}
	public void setSelectedReservedById(int selectedReservedById) {
		this.selectedReservedById = selectedReservedById;
	}
	public int selectedPersonById;
	public int selectedInterviewById;
	public int selectedReservedById;
	public int getSelectedInterviewById() {
		return selectedInterviewById;
	}
	public void setSelectedInterviewById(int selectedInterviewById) {
		this.selectedInterviewById = selectedInterviewById;
	}
	public void setInterviews(List<Interview> interviews) {
		Interviews = interviews;
	}
	public int getSelectedPersonById() {
		return selectedPersonById;
	}
	public void setSelectedPersonById(int selectedPersonById) {
		this.selectedPersonById = selectedPersonById;
	}
	@EJB
	InterviewService Iservice;
	@EJB
	PersonService Pservice;
	@EJB
	ReservedService Rservice;
	@EJB
	FixedService Fservice;
	
	/*public void addInterview() { 
		Iservice.addInterview(new Interview(date)); }
	*/
	public Date getTodaysdate() throws ParseException {
		
		String today = java.time.LocalDate.now().toString();  
   	    newDate=new SimpleDateFormat("yyyy-MM-dd").parse(today); 
   	    return newDate;
	}
	public String addTimezone() {
		String navigateTo= "null";
		navigateTo= "/AddInterview?faces-redirect=true";
		return navigateTo;
	}
	public void addInterview(int personId){
		Person person=Pservice.getPersonById(personId);
		Interview inter= new Interview(date);
		inter.setPerson(person);
		Iservice.addInterview(inter);
		FacesContext.getCurrentInstance().addMessage("form:btn", new FacesMessage("Formation ajoutée avec succès !"));
		
		
	}
	public Date dateR;
	//public int ReservedId;
	public void addReserved(Interview inter, Date date,int id){
		
		if(Rservice.SearchRes(dateR, id)==1 ) {
			//Interview intervieww = new Interview(SelectedCapacityTobeUpdated,capacity);
	  		Iservice.updateInterviewRes(id);
		}else if(Rservice.SearchRes(dateR, id)==0 ){
			this.setInterviewId(inter.getInterviewId());
			this.setDate(inter.getDate());
			
			Interview interview=Rservice.getInterviewById(interviewId);
			Reserved res= new Reserved(); 
			//capacity++;
			
			res.setInterview(inter);
			res.setDate(date);	
			//res.setCapacity(capacity);
			Rservice.addReserved(res);
			//Interview intervieww = new Interview(SelectedCapacityTobeUpdated,capacity);
	  		Iservice.updateInterviewRes(id);
		}
		
	}
	
	public void addReservedF(Interview inter, Date date,int id) {
		this.setInterviewId(inter.getInterviewId());
		this.setDate(inter.getDate());
		
		Interview interview=Rservice.getInterviewById(interviewId);
		Reserved res= new Reserved(); 
		//capacity++;
		
		res.setInterview(inter);
		res.setDate(date);	
		//res.setCapacity(capacity);
		Rservice.addReserved(res);
		//Interview intervieww = new Interview(SelectedCapacityTobeUpdated,capacity);
  		Iservice.updateInterviewRes(id);
	}
	public void addFixed(Reserved inter, Date date,int id){
		this.setReservedId(inter.getReservedId());
		this.setDate(inter.getDate());
		
		Reserved reserved=Fservice.getReservedById(reservedId);
		Fixed fix= new Fixed(); 
		
		
		//capacity=Rservice.CapacityInter(ReservedId);
		fix.setReserved(inter);
		fix.setDate(date);	
		
		Fservice.addFixed(fix);
		Iservice.changeStatusFById(id);
		
		
	}
	
	private void setPerson(Person person) {
		// TODO Auto-generated method stub
		
	}
	public String ManageInterview() {
		String navigateTo= "null";
		navigateTo= "/Interview/ajoutInter?faces-redirect=true";
		return navigateTo;
	}
	public String ReservedInterview() {
		String navigateTo= "null";
		navigateTo= "/Interview/ReservedListInterview?faces-redirect=true";
		return navigateTo;
	}
	
	public String ReserveInterview() {
		String navigateTo= "null";
		navigateTo= "/Interview/ListInterviewDispo?faces-redirect=true";
		return navigateTo;
	}
	
	public String FixedInterview() {
		String navigateTo= "null";
		navigateTo= "/Interview/FixedListInterview?faces-redirect=true";
		return navigateTo;
	}
	
	public String StatusInterview() {
		String navigateTo= "null";
		navigateTo= "/Interview/Status?faces-redirect=true";
		return navigateTo;
	}
	public String ViewList() {
		String navigateTo= "null";
		navigateTo= "/Interview/ListInterview?faces-redirect=true";
		return navigateTo;
	}
	private List<Interview> Interviews;
	public List<Interview> getInterviews(){
		Interviews = Iservice.getAllInterview();
		return Interviews;
	}
	
	private List<Reserved> Reserveds;
	public List<Reserved> getReserveds(){
		Reserveds = Rservice.getAllReserved();
		return Reserveds;
	}
	private List<Fixed> Fixeds;
	public List<Fixed> getFixeds(){
		Fixeds = Fservice.getAllFixed();
		return Fixeds;
	}

	
	public void setReserveds(List<Reserved> reserveds) {
		Reserveds = reserveds;
	}
	
	public void setFixeds(List<Fixed> fixeds) {
		Fixeds = fixeds;
	}
	public void displayInterview(Interview inter) {		
 		this.setDate(inter.getDate());
 		this.setSelectedDateTobeUpdated(inter.getInterviewId());
 	}
	
	public void displayReserved(Reserved inter) {		
 		this.setCapacity(inter.getCapacity());
 		this.setSelectedCapacityTobeUpdated(inter.getCapacity()+1);
 	}
     
     public void updateInterview()
 	{ 	
 		Interview interview = new Interview(SelectedDateTobeUpdated,date);
 		Iservice.updateInterview(interview);
 	}
     public void updateRes(int id)
  	{ 	
  		Interview interview = new Interview(SelectedCapacityTobeUpdated,capacity);
  		Iservice.updateInterviewRes(id);
  	}
	
     public void deleteInterview(int id) {
  		Iservice.deleteInterviewById(id);
  	}
     public void deleteFixed(int id) {
   		Fservice.deleteFixedById(id);
   	}
     public void deleteReserved(int id,int id2,int id3) {
   		Rservice.deleteReservedById(id);
   		Iservice.changeStatusById(id2);
   		Interview intervieww = new Interview(SelectedCapacityTobeUpdated,capacity);
  		Iservice.updateInterviewResMinus(id3);
   	}
     
     public String cancelReserved(int id,int id2) {
    		Rservice.deleteReservedById(id);
    		Iservice.changeStatusCById(id2);
    		String navigateTo= "null";
    		navigateTo= "/Interview/ListInterviewDispo?faces-redirect=true";
    		return navigateTo;
    	}
     
     public void AcceptReserved(int id) {
    		Iservice.changeStatusAById(id);
    	}
	
     public String GoHome() {
 		String navigateTo= "null";
 		navigateTo= "/AdminHome?faces-redirect=true";
 		return navigateTo;
 	}
     public String GoUHome() {
  		String navigateTo= "null";
  		navigateTo= "/UserHome?faces-redirect=true";
  		return navigateTo;
  	}
	
	
	
	
	
	
	
	
	
	public Date getNewDate() {
		return newDate;
	}
	public void setNewDate(Date newDate) {
		this.newDate = newDate;
	}
	public int getSelectedDateTobeUpdated() {
		return SelectedDateTobeUpdated;
	}
	public void setSelectedDateTobeUpdated(int selectedDateTobeUpdated) {
		SelectedDateTobeUpdated = selectedDateTobeUpdated;
	}
	public int getInterviewId() {
		return interviewId;
	}
	public static long getSerialversionuid() {
		return serialVersionUID;
	}

	public void setInterviewId(int interviewId) {
		this.interviewId = interviewId;
	}
	
	public int getReservedId() {
		return reservedId;
	}
	public void setReservedId(int reservedId) {
		this.reservedId = reservedId;
	}
	public int getCapacity() {
		return capacity;
	}
	public void setCapacity(int capacity) {
		this.capacity = capacity;
	}
	public Date getDate() {
		return date;
	}
	public void setDate(Date date) {
		this.date = date;
	}
	
	


}
