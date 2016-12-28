(function ($) {
    var PREFIX = 'mini-preview';
    $.fn.miniPreview = function (options) {
        return this.each(function () {
            var $this = $(this);
            var miniPreview = $this.data(PREFIX);
            if (miniPreview) {
                miniPreview.destroy();
            }
            miniPreview = new MiniPreview($this, options);
            miniPreview.generate();
            $this.data(PREFIX, miniPreview);
        });
    };
    var MiniPreview = function ($el, options) {
        this.$el = $el;
        this.$el.addClass(PREFIX + '-anchor');
        this.options = $.extend({}, this.defaultOptions, options);
        this.counter = MiniPreview.prototype.sharedCounter++;
    };
    MiniPreview.prototype = {
        sharedCounter: 0,
        defaultOptions: {
            height: 200,
            width:200,
            scale: .75,
            prefetch: 'pageload'
        },
        generate: function () {
            this.createElements();
            this.setPrefetch();
        },
        createElements: function () {
            var $wrapper = $('<div>', {
                class: PREFIX + '-wrapper'
            });
            var $loading = $('<div>', {
                class: PREFIX + '-loading'
            });
            var $frame = $('<iframe>', {
                class: PREFIX + '-frame'
            });
            var $cover = $('<div>', {
                class: PREFIX + '-cover'
            });
            $wrapper.appendTo(this.$el).append($loading, $frame, $cover);
            $wrapper.css({
                width: this.options.width + 'px',
                height: this.options.height + 'px'
            });
            var inversePercent = 100 / this.options.scale;
            $frame.css({
                width: inversePercent + '%',
                height: inversePercent + '%',
                transform: 'scale(' + this.options.scale + ')'
            });
            var fontSize = parseInt(this.$el.css('font-size').replace('px', ''), 10)
            var top = (this.$el.height() + fontSize) / 2;
            var left = (this.$el.width() - $wrapper.outerWidth()) / 2;
            $wrapper.css({
                top: top + 'px',
                left: left + 'px'
            });
        },
        setPrefetch: function () {
            switch (this.options.prefetch) {
                case 'pageload':
                    this.loadPreview();
                    break;
                case 'parenthover':
                    this.$el.parent().one(this.getNamespacedEvent('mouseenter'), this.loadPreview.bind(this));
                    break;
                case 'none':
                    this.$el.one(this.getNamespacedEvent('mouseenter'), this.loadPreview.bind(this));
                    break;
                default:
                    throw 'Prefetch setting not recognized: ' + this.options.prefetch;
                    break;
            }
        },
        loadPreview: function () {
            this.$el.find('.' + PREFIX + '-frame').attr('src', this.$el.attr('href')).on('load', function () {
                $(this).css('background-color', '#fff');
            });
        },
        getNamespacedEvent: function (event) {
            return event + '.' + PREFIX + '_' + this.counter;
        },
        destroy: function () {
            this.$el.removeClass(PREFIX + '-anchor');
            this.$el.parent().off(this.getNamespacedEvent('mouseenter'));
            this.$el.off(this.getNamespacedEvent('mouseenter'));
            this.$el.find('.' + PREFIX + '-wrapper').remove();
        }
    };
})(jQuery);