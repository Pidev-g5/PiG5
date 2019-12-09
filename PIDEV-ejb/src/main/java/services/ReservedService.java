package services;

import java.util.Date;
import java.util.List;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;
import javax.persistence.TypedQuery;


import interfaces.ReservedInterfaceLocal;
import interfaces.ReservedInterfaceRemote;
import model.Interview;
import model.Reserved;
@Stateless
@LocalBean
public class ReservedService implements ReservedInterfaceLocal, ReservedInterfaceRemote{
	
@PersistenceContext(unitName="primary")
	
	EntityManager em;

	@Override
	public Interview getInterviewById(int interviewId) {
		TypedQuery<Interview> query = 
				em.createQuery("select e from Interview e WHERE e.interviewId=:interviewId ", Interview.class); 
				query.setParameter("interviewId",interviewId); 
				Interview interview = null; 
				try {
					interview = query.getSingleResult(); 
				}
				catch (Exception e) {
					System.out.println("Erreur : " + e);
				}
				return interview;
	}
	@Override
	public Reserved getReservedById(int reservedId) {
		TypedQuery<Reserved> query = 
				em.createQuery("select e from Reserved e WHERE e.reservedId=:reservedId ", Reserved.class); 
				query.setParameter("reservedId",reservedId); 
				Reserved reserved = null; 
				try {
					reserved = query.getSingleResult(); 
				}
				catch (Exception e) {
					System.out.println("Erreur : " + e);
				}
				return reserved;
	}

	@Override
	public int addReserved(Reserved r) {
		em.persist(r);
 		return r.getReservedId();
	}
	
	@Override
	public List<Reserved> getAllReserved() {
		List<Reserved> reserveds = em.createQuery("Select a from Reserved a", Reserved.class).getResultList();
		return reserveds;
	}
	@Override
	public void deleteReservedById(int ReservedId) {
		Reserved p = em.find(Reserved.class,ReservedId);
		em.remove(p);	
		
	}
    
	@Override
	public int CapacityInter(int ReservedId) {
		
		
		String sql = "select count(o.reservedId)from Reserved o where o.reservedId=:reservedId ";
		Query q = em.createQuery(sql);
		q.setParameter("reservedId", ReservedId);
		int count = (int)q.getSingleResult();
		
		
		//Query  query = em.createQuery("select count(*) from Offre o where o.idOffre=:IdOffre ");
		//query.setParameter("idOffre", IdOffre);
		

		System.out.println(ReservedId);
		return count;
	}
	public int newcapacity;
	@Override
	public void changeCapacityById(int ReservedId) {
		Reserved f = em.find(Reserved.class,ReservedId);
		newcapacity++;
		f.setCapacity(newcapacity);
 		
		
	}
	@Override
	public void updateReserved(Reserved p) {

		Query query = em.createQuery("update Reserved e set e.capacity=:Capacity where e.reservedId=:ReservedId");
		query.setParameter("Capacity", p.getCapacity()+1);
		query.setParameter("ReservedId", p.getReservedId());
		query.executeUpdate();
			
	}
	
	@Override
	public int SearchRes(Date dateR, int interviewId) {
		Interview f = em.find(Interview.class,interviewId);
		dateR=f.getDate();
		TypedQuery<Reserved> query = em.createQuery("Select t from Reserved t where t.date=:dateR", Reserved.class);
		//query.setParameter("dateR", dateR);
		query.setParameter("dateR", dateR).getSingleResult();
		Reserved Ah =query.setParameter("dateR", dateR).getSingleResult();
		if(Ah==null) {
			return 0;
		} else return 1;
		
		
		
		//query.setFirstResult(interviewId);
		//return query.getFirstResult();
		
		//return query.getResultList();

	}
}
