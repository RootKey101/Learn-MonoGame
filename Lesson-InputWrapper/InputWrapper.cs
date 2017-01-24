using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace InputWrapperProject
{
    internal struct InputButtons // This is internal class (we can access it from all the assembly) this is also a struct (good for encapsulation of a little group of variables linked).
    {
        /*
         Here we put two paramaters, key1 and key2,
         Then we check when one of these key is pressed,
         if one of the two key is pressed, the GetState methods
         return "ButtonState.Pressed" else it return
         "ButtonState.Released".
        */
        private ButtonState GetState(Keys key1, Keys key2)
        {
            if (Keyboard.GetState().IsKeyDown(key1))
                return ButtonState.Pressed;

            if (Keyboard.GetState().IsKeyDown(key2))
                return ButtonState.Pressed;

            return ButtonState.Released;
        }

        /*
         Now we create our custom inputs, for the first 
         custom input called "Up" i choose to assign the
         key "Z" and "Upper arrow". 
         So now if i choose to use my "Up" custom input for
         move up an object. it will work with "Z" and "upper arrow"
         too.
         */
        public ButtonState Up {
            get { return GetState(Keys.Z, Keys.Up); }}

        public ButtonState Down {
            get { return GetState(Keys.S, Keys.Down); }}

        public ButtonState Left {
            get { return GetState(Keys.Q, Keys.Left); }}

        public ButtonState Right {
            get { return GetState(Keys.D, Keys.Right); }}
    }

    abstract class InputWrapper //abstract because we don't have to create instance of InputWrapper.
    {
        static public InputButtons Buttons = new InputButtons(); // Now we create a new static instance of our InputButtons. (static for access it everywhere).
    }
}
