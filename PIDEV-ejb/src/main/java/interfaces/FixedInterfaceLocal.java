package interfaces;

import java.util.List;

import javax.ejb.Local;

import model.Fixed;
import model.Interview;
import model.Reserved;

@Local
public interface FixedInterfaceLocal {
	public int addFixed(Fixed r);
	public Reserved getReservedById(int reservedId);
	public void deleteFixedById(int FixedId);
	public List<Fixed> getAllFixed();
	
}
