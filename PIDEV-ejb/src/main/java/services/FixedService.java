package services;

import java.util.List;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;
import javax.persistence.TypedQuery;

import interfaces.FixedInterfaceLocal;
import interfaces.FixedInterfaceRemote;
import interfaces.ReservedInterfaceLocal;
import interfaces.ReservedInterfaceRemote;
import model.Fixed;
import model.Interview;
import model.Reserved;

@Stateless
@LocalBean
public class FixedService implements FixedInterfaceLocal, FixedInterfaceRemote{
@PersistenceContext(unitName="primary")
	
	EntityManager em;

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
	public int addFixed(Fixed r) {
		em.persist(r);
 		return r.getFixedId();
	}
	
	@Override
	public List<Fixed> getAllFixed() {
		List<Fixed> fixeds = em.createQuery("Select a from Fixed a", Fixed.class).getResultList();
		return fixeds;
	}
	@Override
	public void deleteFixedById(int FixedId) {
		Fixed p = em.find(Fixed.class,FixedId);
		em.remove(p);	
		
	}
	
	
    
}
