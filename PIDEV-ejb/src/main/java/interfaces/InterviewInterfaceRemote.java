package interfaces;

import java.util.List;


import javax.ejb.Remote;

import model.Interview;
import model.Reserved;
@Remote
public interface InterviewInterfaceRemote {
	public int addInterview(Interview o);
	public List<Interview> getAllInterview();
	public void updateInterview(Interview p);
	public void deleteInterviewById(int InterviewId);
	public void changeStatusById(int InterviewId);
	public void changeStatusAById(int InterviewId);
	public void changeStatusCById(int InterviewId);
	public void changeStatusFById(int InterviewId);
	public void updateInterviewRes(int InterviewId);
	public void updateInterviewResMinus(int InterviewId);
}
