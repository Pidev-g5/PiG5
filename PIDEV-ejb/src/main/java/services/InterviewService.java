package services;

import java.util.ArrayList;
import java.util.List;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;
import javax.persistence.TypedQuery;

import interfaces.InterviewInterfaceLocal;
import interfaces.InterviewInterfaceRemote;
import model.Interview;
import model.Person;
import model.Reserved;




@Stateless
@LocalBean
public class InterviewService implements InterviewInterfaceLocal, InterviewInterfaceRemote{

	@PersistenceContext(unitName="primary")
	
	EntityManager em;
	
	@Override
	public int addInterview(Interview o) {
		em.persist(o);
 		return o.getInterviewId();
	}
	
	
	@Override
	public List<Interview> getAllInterview() {
		List<Interview> interviews = em.createQuery("Select a from Interview a", Interview.class).getResultList();
		return interviews;
	}
	
	@Override
	public void updateInterview(Interview p) {

		Interview inter = em.find(Interview.class, p.getInterviewId()); 

		inter.setDate(p.getDate());
			
	}
	public int newcapacity;
	@Override
	public void updateInterviewRes(int InterviewId) {
		Interview f = em.find(Interview.class,InterviewId);
		newcapacity++;
		f.setCapacity(newcapacity);
		//Query query = em.createQuery("update Interview e set e.capacity=:Capacity where e.interviewId=:InterviewId");
		//query.setParameter("Capacity", p.getCapacity()+1);
		//query.setParameter("ReservedId", p.getReservedId());
		//query.executeUpdate();
			
	}
	
	@Override
	public void updateInterviewResMinus(int InterviewId) {
		Interview f = em.find(Interview.class,InterviewId);
		newcapacity=f.getCapacity()-1;
		f.setCapacity(newcapacity);
		//Query query = em.createQuery("update Interview e set e.capacity=:Capacity where e.interviewId=:InterviewId");
		//query.setParameter("Capacity", p.getCapacity()+1);
		//query.setParameter("ReservedId", p.getReservedId());
		//query.executeUpdate();
			
	}
	@Override
	public void deleteInterviewById(int InterviewId) {
		Interview p = em.find(Interview.class,InterviewId);
		em.remove(p);	
		
	}
	public String newstatus;
	@Override
	public void changeStatusById(int InterviewId) {
		Interview f = em.find(Interview.class,InterviewId);
		newstatus="Rejected";
		f.setStatus(newstatus);
 		
		
	}
	@Override
	public void changeStatusAById(int InterviewId) {
		Interview f = em.find(Interview.class,InterviewId);
		newstatus="Accepted";
		f.setStatus(newstatus);
 		
		
	}
	
	@Override
	public void changeStatusCById(int InterviewId) {
		Interview f = em.find(Interview.class,InterviewId);
		newstatus=" ";
		f.setStatus(newstatus);
 		
		
	}
	@Override
	public void changeStatusFById(int InterviewId) {
		Interview f = em.find(Interview.class,InterviewId);
		newstatus=" Confirmed ";
		f.setStatus(newstatus);
 		
		
	}

	
	

	
	
}
