//using LekarClass;
//using System;
//using System.Windows.Forms;
//using System.Drawing;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Windows.Forms.VisualStyles;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.ComponentModel.Design.Serialization;
//using System.Drawing.Design;

//namespace LekarList
//{

//    public class TreeGridView : DataGridView
//    {
//        private int _indentWidth;
//        private TreeGridNode _root;
//        private TreeGridColumn _expandableColumn;
//        private bool _disposing = false;

//        private bool _inExpandCollapse = false;
//        internal bool _inExpandCollapseMouseCapture = false;
//        private Control hideScrollBarControl;
//        private bool _showLines = true;
//        private bool _virtualNodes = false;

//        internal VisualStyleRenderer rOpen = new VisualStyleRenderer(VisualStyleElement.TreeView.Glyph.Opened);
//        internal VisualStyleRenderer rClosed = new VisualStyleRenderer(VisualStyleElement.TreeView.Glyph.Closed);

//    }
//    public class TreeGridNode : DataGridViewRow//, IComponent
//    {
//        internal TreeGridView _grid;
//        internal TreeGridNode _parent;
//        internal TreeGridNodeCollection _owner;
//        internal bool IsExpanded;
//        internal bool IsRoot;
//        internal bool _isSited;
//        internal bool _isFirstSibling;
//        internal bool _isLastSibling;
//        internal Image _image;
//        internal int _imageIndex;

//        private Random rndSeed = new Random();
//        public int UniqueValue = -1;
//        TreeGridCell _treeCell;
//        TreeGridNodeCollection childrenNodes;

//        private int _index;
//        private int _level;
//        private bool childCellsCreated = false;

//        // needed for IComponent
//        private ISite site = null;
//        private EventHandler disposed = null;

//        internal TreeGridNode(TreeGridView owner)
//            : this()
//        {
//            this._grid = owner;
//            this.IsExpanded = true;
//        }

//        public TreeGridNode()
//        {
//            _index = -1;
//            _level = -1;
//            IsExpanded = false;
//            UniqueValue = this.rndSeed.Next();
//            _isSited = false;
//            _isFirstSibling = false;
//            _isLastSibling = false;
//            _imageIndex = -1;
//        }
//        public virtual bool HasChildren
//        {
//            get
//            {
//                return (this.childrenNodes != null && this.Nodes.Count != 0);
//            }
//        }
//        public TreeGridNodeCollection Nodes
//        {
//            get
//            {
//                if (childrenNodes == null)
//                {
//                    childrenNodes = new TreeGridNodeCollection(this);
//                }
//                return childrenNodes;
//            }
//            set {; }
//        }
//        internal protected virtual bool AddChildNode(TreeGridNode node)
//        {
//            node._parent = this;
//            node._grid = this._grid;

//            // ensure that all children of this node has their grid set
//            if (this._grid != null)
//                UpdateChildNodes(node);

//            if ((this._isSited || this.IsRoot) && this.IsExpanded && !node._isSited)
//                this._grid.SiteNode(node);

//            return true;
//        }

//    }

//    public class TreeGridNodeCollection //: System.Collections.Generic.IList<TreeGridNode>, System.Collections.IList
//    {
//        internal System.Collections.Generic.List<TreeGridNode> _list;
//        internal TreeGridNode _owner;
//        internal TreeGridNodeCollection(TreeGridNode owner)
//        {
//            this._owner = owner;
//            this._list = new List<TreeGridNode>();
//        }
//        #region Public Members
//        public void Add(TreeGridNode item)
//        {
//            // The row needs to exist in the child collection before the parent is notified.
//            item._grid = this._owner._grid;

//            bool hadChildren = this._owner.HasChildren;
//            item._owner = this;

//            this._list.Add(item);

//            this._owner.AddChildNode(item);

//            // if the owner didn't have children but now does (asserted) and it is sited update it
//            if (!hadChildren && this._owner.IsSited)
//            {
//                this._owner._grid.InvalidateRow(this._owner.RowIndex);
//            }
//        }
//        #endregion
//        public int Count
//        {
//            get { return this._list.Count; }
//        }


//    }
//    public class TreeGridCell : DataGridViewTextBoxCell
//    {
//        private const int INDENT_WIDTH = 20;
//        private const int INDENT_MARGIN = 5;
//        private int glyphWidth;
//        private int calculatedLeftPadding;
//        internal bool IsSited;
//        private Padding _previousPadding;
//        private int _imageWidth = 0, _imageHeight = 0, _imageHeightOffset = 0;
//        private Rectangle _lastKnownGlyphRect;

//        public TreeGridCell()
//        {
//            glyphWidth = 15;
//            calculatedLeftPadding = 0;
//            this.IsSited = false;

//        }
//    }
//    public class TreeGridColumn : DataGridViewTextBoxColumn
//    {
//        internal Image _defaultNodeImage;

//        public TreeGridColumn()
//        {
//            this.CellTemplate = new TreeGridCell();
//        }
//    }

    

//}
