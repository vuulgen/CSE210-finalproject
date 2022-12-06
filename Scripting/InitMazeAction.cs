using System.Collections.Generic;
using PucMan.Game.Casting;
using PucMan.Game.Services;


namespace PucMan.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class InitMazeAction : Action
    {
        private bool initialized = false;
        /// <summary>
        /// Constructs a new instance of DrawActorsAction using the given KeyboardService.
        /// </summary>
        public InitMazeAction()
        {

        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (initialized == false)
                {
                    //Create all the actors for the maze and add them to the cast

                }
            initialized = true;
        }
    }
}