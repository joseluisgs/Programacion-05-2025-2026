namespace InterfacesHerenciaMultiple.Models;

public interface IMotorElectrico : IMotor, IElectrico {
    void Explotar();
}