using System.Collections.Generic;

class Sprite 
{
    protected string name;
    protected List<string> keywords;
    protected List<Keyword_Odds> neighbor_keywords;

    public virtual List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords;
    }
    public virtual List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords;
    }
    public virtual List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords;
    }
    public virtual List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords;
    }



    public class Keyword_Odds
    {
        protected string name;
        protected int weight;
    }
}

class Sprite_T : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
}
class Sprite_L : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_L;
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
}
class Sprite_R : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_R;
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
}
class Sprite_B : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_TR : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_R;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
}
class Sprite_TL : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_L;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
}
class Sprite_TB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_RL : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_R;
    protected List<Keyword_Odds> neighbor_keywords_L;
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
}
class Sprite_RB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_R;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_LB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_L;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_TRL : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_R;
    protected List<Keyword_Odds> neighbor_keywords_L;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
}
class Sprite_TRB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_R;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_TLB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_L;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_RLB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_R;
    protected List<Keyword_Odds> neighbor_keywords_L;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}
class Sprite_TRLB : Sprite
{
    protected List<Keyword_Odds> neighbor_keywords_T;
    protected List<Keyword_Odds> neighbor_keywords_R;
    protected List<Keyword_Odds> neighbor_keywords_L;
    protected List<Keyword_Odds> neighbor_keywords_B;
    public override List<Keyword_Odds> GetTop()
    {
        return neighbor_keywords_T;
    }
    public override List<Keyword_Odds> GetLeft()
    {
        return neighbor_keywords_L;
    }
    public override List<Keyword_Odds> GetRight()
    {
        return neighbor_keywords_R;
    }
    public override List<Keyword_Odds> GetBottom()
    {
        return neighbor_keywords_B;
    }
}