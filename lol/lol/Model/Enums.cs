namespace lol.Model
{
    /// <summary>
    /// 팀 진행방향
    /// </summary>
    public enum eDirection
    {
        Upper, // 위쪽방향
        Under, // 아랫방향
    }

    public enum eEvent
    {
        Faint, // 기절
        Airborne, // 공중에 뜸
        None, // 없음
    }

    public enum ePosition
    {
        JUNGLEER, // 정글
        MARKSMAN, // 원딜
        MIDLINER, // 미드
        SUPPORTER, // 서폿
        TANKER, // 탑
    }

    public enum eLocation
    {
        MID, // 중앙진영
        TOP, // 위쪽진영
        BOTTOM, // 아래쪽진영
        STORE, // 상점
        RESPAWN, // 우물
        DRAGON, // 드래곤진영
        BARIN_NASHOR, // 내셔남작 진영
        GOLEM_BULE, // 블루골렘
        GOLEM_RED, // 레드골렘
        GOLEM, // 골램
        WOLF, // 늑대
        BLADEBILL, // 칼날부리
    }
}