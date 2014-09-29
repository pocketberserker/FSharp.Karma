namespace FSharp.Karma

type Alternative<'F> =
  inherit Applicative<'F>
  inherit PlusEmpty<'F>
