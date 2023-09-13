using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Infrastructure
{
  public class Game : MonoBehaviour
  {
    public static IInputService InputService;

    public Game()
    {
      RegisterInputService();
    }

    private static void RegisterInputService()
    {
      if (Application.isEditor)
        InputService = new InputService();
    }
  }
}